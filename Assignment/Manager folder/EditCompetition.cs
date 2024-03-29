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
    public partial class frmComEdit : Form
    {
        private object listboxComSelects;
        
        public frmComEdit()
        {
            InitializeComponent();
        }

        private void btnEditCom_Click(object sender, EventArgs e)
        {
            if (listboxComSelects == null)
            {
                MessageBox.Show("Please select a competition from the list.");
                return;
            }

         
            string selectedCompetitionName = listboxComSelects.ToString();

            
            DateTime newDate;
            string newLocation = txtComLocation.Text;
            string newDescription = txtComDescription.Text;


            
            if (!DateTime.TryParse(txtComDate.Text, out newDate))
            {
                MessageBox.Show("Please enter a valid date for the competition in yyyy-MM-dd format.");
                return;
            }

            
            ClassEditCompetition EditCompetition = new ClassEditCompetition(selectedCompetitionName, newDate, newLocation, newDescription);

            string connectionString = ConfigurationManager.ConnectionStrings["Competition"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    ClassEditCompetition competition = new ClassEditCompetition(selectedCompetitionName, newDate, newLocation, newDescription);
                    string result = competition.UpdateCompetition(connection);
                    MessageBox.Show(result);
                }

            }
        }

        private void PopulateListBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Competition"].ConnectionString;
            string query = "SELECT name FROM Competitions";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }

        private void listboxComSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
                
                if (listboxComSelects != null)
                {
                    string selectedCompetitionName = listboxComSelects.ToString();

                    string connectionString = ConfigurationManager.ConnectionStrings["Competition"].ConnectionString;
                    string query = "SELECT * FROM Competitions WHERE name = @name";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", selectedCompetitionName);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                          
                            txtComDate.Text = reader["date"].ToString(); 
                            txtComLocation.Text = reader["location"].ToString();
                            txtComDescription.Text = reader["description"].ToString();
                        }

                        reader.Close();
                    }
                }
 
        }
    }
}
