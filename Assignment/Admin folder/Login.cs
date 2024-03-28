using hehehe;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        private readonly SqlHelper sqlhelper;

        public Login()
        {
            InitializeComponent();
            sqlhelper = new SqlHelper();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string status = loginUser(email, password);

            if (status != null)
            {
                MessageBox.Show(status);
            }
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        private string loginUser(string email, string password)
        {
            string status = null;

            try
            {
                // Check if the email and password combination exists in the database
                string query = "SELECT COUNT(*) FROM users WHERE email = @email AND password = @password";
                // Collect key value pair for column in database and the argument in the method
                var parameters = new Dictionary<string, object>
                {
                    { "@email", email },
                    { "@password", password }
                };
                sqlhelper.openCon();
                int count = Convert.ToInt32(sqlhelper.executeScalar(query, parameters));

                if (count > 0)
                {
                    // Retrieve the user's role
                    query = "SELECT role FROM users WHERE email = @email";
                    string userRole = sqlhelper.executeScalar(query, parameters).ToString();

                    // Open corresponding form based on user role
                    switch (userRole)
                    {
                        case "admin":
                            AdminHome adminHome = new AdminHome(email);
                            adminHome.ShowDialog();
                            break;
                        case "member":
                            MemberHome memberHome = new MemberHome();
                            memberHome.ShowDialog();
                            break;
                        case "coach":
                            CoachMenu coachMenu = new CoachMenu(email);
                            coachMenu.ShowDialog();
                            break;
                        case "manager":
                            homeManager managerHome = new homeManager();
                            managerHome.ShowDialog();
                            break;
                        default:
                            status = "Unsupported user role.";
                            break;
                    }
                }
                else
                {
                    status = "Incorrect username/password";
                }
            }
            catch (Exception ex)
            {
                status = "Error: " + ex.Message;
            }
            finally
            {
                sqlhelper.closeCon();
            }

            return status;
        }
    }
}
