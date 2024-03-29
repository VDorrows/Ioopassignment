using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

     class ClassEditCompetition
     {
        private int competitionId;
        private string name;
        private DateTime? date;
        private string location;
        private string description;
        private string selectedCompetitionName;
        private DateTime newDate;
        private string newLocation;
        private string newDescription;

        public ClassEditCompetition(string selectedCompetitionName, DateTime newDate, string newLocation, string newDescription)
        {
            this.selectedCompetitionName = selectedCompetitionName;
            this.newDate = newDate;
            this.newLocation = newLocation;
            this.newDescription = newDescription;
        }

        public ClassEditCompetition(int competitionId, string name, DateTime? date, string location, string description)
        {
            this.competitionId = competitionId;
            this.name = name;
            this.date = date;
            this.location = location;
            this.description = description;
        }

        public string UpdateCompetition(SqlConnection connection)
        {
            try
            {
                string query = "UPDATE Competitions SET name = @name, date = @date, location = @location, description = @description WHERE competitionId = @competitionId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@competitionId", competitionId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date.HasValue ? (object)date.Value : DBNull.Value); 
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@description", description);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0 ? "Competition updated successfully." : "Failed to update competition.";
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

}
