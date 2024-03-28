using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class Add_user
    {
        private string email;
        private string password;
        private string userName;
        private string additionalInfo;
        private SqlHelper sqlhelper;

        public Add_user(string email, string password, string userName, string additionalInfo)
        {
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.additionalInfo = additionalInfo;
            sqlhelper = new SqlHelper();
        }

        public string addUser(string userRole)
        {
            string status;
            SqlTransaction transaction = null;
            try
            {
                sqlhelper.openCon();
                if (emailExists(email))
                {
                    status = "Email already exists in the database.";
                }
                else
                {
                    // Begin transaction
                    transaction = sqlhelper.beginTransaction();

                    // Insert data into the user table
                    var userData = new Dictionary<string, object>
                    {
                        { "email", email },
                        { "password", password },
                        { "username", userName },
                        { "role", userRole }
                    };
                    sqlhelper.addData("users", userData, transaction);

                    // Insert additional data based on user role
                    var additionalData = new Dictionary<string, object>();
                    switch (userRole)
                    {
                        case "coach":
                            additionalData.Add("email", email);
                            additionalData.Add("traininglevel", additionalInfo.Split('|')[0]);
                            additionalData.Add("salary", additionalInfo.Split('|')[1]);
                            break;
                        case "manager":
                            additionalData.Add("email", email);
                            additionalData.Add("salary", additionalInfo);
                            break;
                        case "member":
                            additionalData.Add("email", email);
                            additionalData.Add("traininglevel", additionalInfo);
                            break;
                        default:
                            break;
                    }

                    // Use the AddData method to insert additional data
                    sqlhelper.addData(userRole, additionalData, transaction);

                    // Commit transaction
                    transaction.Commit();
                    status = "Registration Successful";
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                status = "Unable to Register: " + ex.Message;
            }
            finally
            {
                sqlhelper.closeCon();
            }
            return status;
        }

        private bool emailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @em";
            var parameters = new Dictionary<string, object> { { "@em", email } };
            int count = Convert.ToInt32(sqlhelper.executeScalar(query, parameters));
            return count > 0;
        }
    }
}
