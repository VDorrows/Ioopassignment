using Assignment.Admin_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class AdminHome : Form
    {
        public static string name;
        private const string Suggestion = "Suggestion";
        private const string Income = "Income";
        private const string Competition = "Competition";
        private SqlHelper sqlHelper;

        public AdminHome()
        {
            InitializeComponent();
        }

        public AdminHome(String n)
        {
            InitializeComponent();
            name = n;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblidentity.Text = $"Welcome, {name}";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Adduser ad = new Adduser();
            ad.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmail = tbSearchemail.Text.Trim();
            SqlHelper sqlHelper = new SqlHelper(); //Initiate Class Sql
            SearchUser searchUser = new SearchUser(sqlHelper); //Initiate Class SearchUser
            searchUser.searchUser(searchEmail, lbluserRole, lblemail, lblpassword, lblusername, lbltraininglevel, lblsalary);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string email = lblemail.Text;
            string password = lblpassword.Text;
            string username = lblusername.Text;
            string userRole = lbluserRole.Text;
            string trainingLevel = lbltraininglevel.Text;
            string salary = lblsalary.Text;
            clearFields();

            if (email == name) //Check if email equals to current user
            {
                Edituser editUser = new Edituser(email, password, username, trainingLevel, salary, userRole, false);
                editUser.ShowDialog();
            }
            else
            {
                Edituser editUser = new Edituser(email, password, username, trainingLevel, salary, userRole, true);
                editUser.ShowDialog();
            }
        }

        private void clearFields()
        {
            lbluserRole.Text = null;
            lblemail.Text = null;
            lblpassword.Text = null;
            lblusername.Text = null;
            lbltraininglevel.Text = null;
            lblsalary.Text = null;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {   
            string n = name;
                // Create an instance of the SearchUser class
                SearchUser searchUser = new SearchUser(new SqlHelper());
                // Search for current user by email
                DataTable userData = searchUser.SearchUserByName(name);
                // Process query results
                if (userData != null && userData.Rows.Count > 0)
                {
                    DataRow userRow = userData.Rows[0];
                    string email = userRow["email"].ToString();
                    string password = userRow["password"].ToString();
                    string username = userRow["username"].ToString();
                    string userRole = userRow["role"].ToString();

                    // Open the Edituser form with the retrieved user data
                    Edituser editUserForm = new Edituser(email, password, username, "", "", userRole, false);
                    editUserForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            
        }

        private void btnviewR_Click(object sender, EventArgs e)
        {
            View vS = new View(Suggestion);
            vS.ShowDialog();
        }

        private void btnviewI_Click_2(object sender, EventArgs e)
        {
            View vI = new View(Income);
            vI.ShowDialog();
        }

        private void btnviewC_Click(object sender, EventArgs e)
        {
            View vC = new View(Competition);
            vC.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}