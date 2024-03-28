using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Assignment.Admin_folder
{
    public class SearchUser
    {
        private readonly SqlHelper sqlHelper;

        public SearchUser(SqlHelper sqlHelper)
        {
            this.sqlHelper = sqlHelper;
        }

        public void searchUser(string email, Label lbluserRole, Label lblemail, Label lblpassword, Label lblusername, Label lbltraininglevel, Label lblsalary)
        {
            try
            {
                sqlHelper.openCon();

                string query = "SELECT * FROM users WHERE email = @Email";
                var parameters = new Dictionary<string, object> { { "@Email", email } };
                DataTable userData = sqlHelper.executeQuery(query, parameters);

                if (userData.Rows.Count > 0)
                {
                    DataRow userRow = userData.Rows[0];
                    lbluserRole.Text = userRow["role"].ToString();
                    lblemail.Text = userRow["email"].ToString();
                    lblpassword.Text = userRow["password"].ToString();
                    lblusername.Text = userRow["username"].ToString();

                    string userRole = userRow["role"].ToString();

                    if (userRole == "coach" || userRole == "member" || userRole == "manager")
                    {
                        DisplayAdditionalInfo(userRole, email, lbltraininglevel, lblsalary);
                    }
                    else
                    {
                        lbltraininglevel.Text = null;
                        lblsalary.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlHelper.closeCon();
            }
        }

        private void DisplayAdditionalInfo(string userRole, string email, Label lbltraininglevel, Label lblsalary)
        {
            try
            {
                string tableName = GetTableName(userRole);

                if (string.IsNullOrEmpty(tableName))
                {
                    lbltraininglevel.Text = null;
                    lblsalary.Text = null;
                    return;
                }

                string query = $"SELECT * FROM {tableName} WHERE email = @Email";
                var parameters = new Dictionary<string, object> { { "@Email", email } };
                DataTable additionalInfoData = sqlHelper.executeQuery(query, parameters);

                if (additionalInfoData.Rows.Count > 0)
                {
                    DataRow additionalInfoRow = additionalInfoData.Rows[0];
                    switch (userRole)
                    {
                        case "coach":
                            lbltraininglevel.Text = additionalInfoRow["traininglevel"]?.ToString();
                            lblsalary.Text = additionalInfoRow["salary"]?.ToString();
                            break;
                        case "member":
                            lbltraininglevel.Text = additionalInfoRow["traininglevel"]?.ToString();
                            lblsalary.Text = null;
                            break;
                        case "manager":
                            lbltraininglevel.Text = null;
                            lblsalary.Text = additionalInfoRow["salary"]?.ToString();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lbltraininglevel.Text = null;
                    lblsalary.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable SearchUserByName(string name)
        {
            try
            {
                // Open the connection
                sqlHelper.openCon();

                // Construct and execute the SQL query
                string query = "SELECT * FROM users WHERE email = @name";
                var parameters = new Dictionary<string, object> { { "@name", name } };
                DataTable userData = sqlHelper.executeQuery(query, parameters);

                return userData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                // Close the connection
                sqlHelper.closeCon();
            }
        }

        private string GetTableName(string userRole)
        {
            switch (userRole)
            {
                case "coach":
                    return "coach";
                case "member":
                    return "member";
                case "manager":
                    return "manager";
                default:
                    return "";
            }
        }
    }
}
