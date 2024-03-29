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
    public partial class frmMberAssign : Form
    {
        public frmMberAssign()
        {
            InitializeComponent();
        }

        private void btnAssignMem_Click(object sender, EventArgs e)
        {
            // Check if both a member and a competition are selected
            if (boxMemSelect.SelectedItem != null && boxComSelect.SelectedItem != null)
            {
                // Retrieve selected member and competition
                string selectedMember = boxMemSelect.SelectedItem.ToString();
                string selectedCompetition = boxComSelect.SelectedItem.ToString();

                // Assign the member to the competition
                if (AssignMemberToCompetition(selectedMember, selectedCompetition))
                {
                    MessageBox.Show($"Member '{selectedMember}' assigned to competition '{selectedCompetition}' successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to assign member '{selectedMember}' to competition '{selectedCompetition}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both a member and a competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AssignMemberToCompetition(string memberName, string competitionName)
        {
            try
            {
                // Perform assignment operation (e.g., update database)
                // Example: Update a table in the database to assign the member to the competition
                string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
                string query = "UPDATE Members SET Competition = @competition WHERE Name = @name";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", memberName);
                    command.Parameters.AddWithValue("@competition", competitionName);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // Return true if at least one row was affected (assignment successful)
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning member to competition: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
