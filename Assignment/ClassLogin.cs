﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ClassLogin
    {
        private string email; private string password; private string username;

        public ClassLogin(string email,string password) 
        {
            this.email = email;
            this.password = password;
        }


        public string Login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where email =@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", email);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select role from users where email =@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", email);
                cmd2.Parameters.AddWithValue("@b", password);

                string userRole = cmd2.ExecuteScalar().ToString();
                string userName = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    AdminHome a = new AdminHome(userName);
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
