using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class User
    {
        private string username; private string password;

        public User(string username,string password) 
        {
            this.username = username;
            this.password = password;
        }


        public string Login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username =@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select role from users where username =@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@b", password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    AdminHome a = new AdminHome();
                    a.ShowDialog();
                }
                else if (userRole == "member")
                {
                    MemberHome m = new MemberHome();
                    m.ShowDialog();
                }
                else if (userRole == "coach")
                {
                    CoachHome c = new CoachHome();
                    c.ShowDialog();
                }
                else if (userRole == "manager")
                {
                    ManagerHome ma = new ManagerHome();
                    ma.ShowDialog();
                }
            }
            else
            {
                status = "Incorrect username/password";
            }
            con.Close();
            return status;
        }
    }
}
