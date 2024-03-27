using hehehe;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        private readonly SqlHelper sqlHelper;

        public Login()
        {
            InitializeComponent();
            sqlHelper = new SqlHelper();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string status = LoginUser(email, password);

            if (status != null)
            {
                MessageBox.Show(status);
            }
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        private string LoginUser(string email, string password)
        {
            string status = null;

            try
            {
                // Check if the email and password combination exists in the database
                string query = "SELECT COUNT(*) FROM users WHERE email = @email AND password = @password";
                var parameters = new Dictionary<string, object>
                {
                    { "@email", email },
                    { "@password", password }
                };

                int count = Convert.ToInt32(sqlHelper.ExecuteScalar(query, parameters));

                if (count > 0)
                {
                    // Retrieve the user's role
                    query = "SELECT role FROM users WHERE email = @email";
                    string userRole = sqlHelper.ExecuteScalar(query, parameters).ToString();

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
                            ManagerHome managerHome = new ManagerHome();
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

            return status;
        }
    }
}
