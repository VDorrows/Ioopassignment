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
    public partial class frmViewMemList : Form
    {
        public frmViewMemList()
        {
            InitializeComponent();
        }

        private void ViewMemberList_Load(object sender, EventArgs e)
        {

        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            
            if (boxComSelect.SelectedItem != null)
            {
                
                string selectedCompetition = boxComSelect.SelectedItem.ToString();

               
                List<string> studentList = GetStudentsForCompetition(selectedCompetition);

 
                DisplayStudents(studentList);
            }
            else
            {
                MessageBox.Show("Please select a competition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetStudentsForCompetition(string competitionName)
        {
            List<string> studentList = new List<string>();

            try
            {
                
                string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
                string query = "SELECT StudentName FROM StudentCompetition WHERE CompetitionName = @competition";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@competition", competitionName);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        studentList.Add(reader["StudentName"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving students for competition: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentList;
        }

        private void DisplayStudents(List<string> studentList)
        {
            
            lstMemView.Items.Clear();

           
            foreach (string studentName in studentList)
            {
                lstMemView.Items.Add(studentName);
            }
        }

    }
}
