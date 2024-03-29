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
    public partial class frmViewCommend : Form
    {
        private object listBoxRecommendedStudents;
        private int coachId;

        public frmViewCommend()
        {
            InitializeComponent();
        }

        
        private List<string> GetRecommendedStudentsForCoach(int coachId)
        {
            List<string> recommendedStudents = new List<string>();

            
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            string query = "SELECT StudentName FROM RecommendedStudents WHERE CoachId = @coachId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@coachId", coachId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recommendedStudents.Add(reader["StudentName"].ToString());
                }

                reader.Close();
            }

            return recommendedStudents;
        }

        private void lstViewCommend_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> recommendedStudents = GetRecommendedStudentsForCoach(coachId);
        }
    }
}
