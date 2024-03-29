using Assignment;    
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
using System.Xml.Linq;

namespace Assignment
{
    public partial class frmComAdd : Form
    {
        public frmComAdd()
        {
            InitializeComponent();
        }

        private void btnAddCom_Click(object sender, EventArgs e)
        {
            string name = txtComName.Text;
            string dateText = txtComDate.Text;
            string location = txtComLocation.Text;
            string description = txtComDescription.Text;

           
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter all details.");
                return;
            }

            
            DateTime date;
            if (!DateTime.TryParse(dateText, out date))
            {
                MessageBox.Show("Invalid date format. Please enter the date in yyyy-MM-dd format.");
                return;
            }

            
            ClassAddCompetition AddCompetition = new ClassAddCompetition(name, date, location, description);

            
            string connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    ClassAddCompetition competition = new ClassAddCompetition(name, date, location, description);
                    string result = competition.AddCompetition (connection);
                    MessageBox.Show(result);
                }
                
            }

            
            txtComName.Clear();
            txtComDate.Clear();
            txtComLocation.Clear();
            txtComDescription.Clear();

        }


    }
    
}
