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

namespace Assignment
{
    public partial class frmComDel : Form
    {
        private object listboxComSelects;
        public frmComDel()
        {
            InitializeComponent();
        }

        private void btnDeleteCom_Click(object sender, EventArgs e)
        {
            
            if (listboxComSelects != null)
            {
                
                string selectedCompetitionName = listboxComSelects.ToString();

                
                DialogResult result = MessageBox.Show("Are you sure you want to delete the competition?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    string connectionString = ConfigurationManager.ConnectionStrings["Competition"].ConnectionString;
                    string query = "DELETE FROM Competitions WHERE name = @name";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", selectedCompetitionName);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                
                                PopulateListBox();
                                MessageBox.Show("Competition deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected. The competition may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting competition: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a competition to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

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

                    reader.Close();
                }
            }
        }
    }
}
