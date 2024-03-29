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
    public partial class frmComResult : Form
    {
        public frmComResult()
        {
            InitializeComponent();
        }

        private void frmComResult_Load(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // Check if a competition is selected
            if (boxComSelect.SelectedItem != null)
            {
                // Retrieve selected competition
                string selectedCompetition = boxComSelect.SelectedItem.ToString();

                // Retrieve result entered by the user
                string result = txtComResult.Text;

                // Record result for selected competition
                RecordResultForCompetition(selectedCompetition, result);
            }
            else
            {
                MessageBox.Show("Please select a competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecordResultForCompetition(string competitionName, string result)
        {
            try
            {
                // Perform database operation to record result for the selected competition
                // Example: Updating a table where competition results are stored
                string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
                string query = "UPDATE CompetitionResults SET Result = @result WHERE CompetitionName = @competition";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@result", result);
                    command.Parameters.AddWithValue("@competition", competitionName);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Result recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows were affected. The competition may not exist or there was an issue recording the result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording result: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
