using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ClassEditUser
    {
        private string email;
        private string password;
        private string userName;
        private string additionalInfo;
        private string userRole;
        private SqlHelper sqlhelper;

        public ClassEditUser(string email, string password, string userName, string additionalInfo, string userRole)
        {
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.additionalInfo = additionalInfo;
            this.userRole = userRole;
            this.sqlhelper = new SqlHelper();
        }

        public string editUser(string userRole)
        {
            sqlhelper.openCon();
            string status;
            SqlTransaction transaction = null;
            try
            {
                transaction = sqlhelper.beginTransaction();
                // Update data in the user table
                var userData = new Dictionary<string, object>
                {
                    { "password", password },
                    { "username", userName }
                };
                sqlhelper.editData("users", "email", email, userData, transaction);

                // Update additional data based on user role
                switch (userRole)
                {
                    case "coach":
                        var coachData = new Dictionary<string, object>
                        {
                            { "traininglevel", additionalInfo.Split('|')[0] },
                            { "salary", additionalInfo.Split('|')[1] }
                        };
                        sqlhelper.editData("coach", "email", email, coachData, transaction);
                        break;
                    case "member":
                        var memberData = new Dictionary<string, object>
                        {
                            { "traininglevel", additionalInfo }
                        };
                        sqlhelper.editData("member", "email", email, memberData, transaction);
                        break;
                    case "manager":
                        var managerData = new Dictionary<string, object>
                        {
                            { "salary", additionalInfo }
                        };
                        sqlhelper.editData("manager", "email", email, managerData, transaction);
                        break;
                    default:
                        break;
                }
                transaction.Commit();
                status = "Update Successful";
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                status = "Update failed: " + ex.Message;
            }
            finally
            {
                sqlhelper.closeCon();
            }
            return status;
        }

        public string deleteUser(string email, string userRole)
        {
            sqlhelper.openCon();
            string status;
            SqlTransaction transaction = null;
            try
            {
                transaction = sqlhelper.beginTransaction();

                // Delete user from the 'users' table
                var userCondition = "email = @email";
                var userParameters = new Dictionary<string, object>
                {
                    { "@email", email }
                };
                sqlhelper.deleteData("users", userCondition, userParameters, transaction);

                // Delete additional data based on user role (except for 'admin')
                if (userRole != "admin")
                {
                    var roleCondition = "email = @email";
                    var roleParameters = new Dictionary<string, object>
                    {
                        { "@email", email }
                    };
                    sqlhelper.deleteData(userRole, roleCondition, roleParameters, transaction);
                }

                // Commit transaction
                transaction.Commit();
                status = "User deleted successfully";
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    // Rollback transaction
                    transaction.Rollback();
                }
                status = "Error deleting user: " + ex.Message;
            }
            finally
            {
                // Close connection
                sqlhelper.closeCon();
            }
            return status;
        }
    }
}