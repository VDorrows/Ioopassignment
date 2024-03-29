using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class ClassAddCompetition
     {
        private string name;
        private DateTime date;
        private string location;
        private string description;

        public ClassAddCompetition(string name, DateTime date, string location, string description)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.description = description;
        }

        public string AddCompetition(SqlConnection connection)
        {
            if (CompetitionExist(connection))
            {
                return "Competition already exists";
            }
            else
            {
                try
                {
                    string query = "INSERT INTO competition (name, date, location, description) VALUES (@name, @date, @location, @description)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@description", description);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Competition added successfully." : "Failed to add competition.";
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private bool CompetitionExist(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM competition WHERE name = @name AND date = @date";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", date);
                int existingCompetitionsCount = (int)command.ExecuteScalar();
                return existingCompetitionsCount > 0;
            }
        }
     }

}
