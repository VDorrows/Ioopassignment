using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public class ClassView
    {
        private readonly string connectionString;

        public ClassView(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private string GetQueryForCommand(string command)
        {
            switch (command)
            {
                case "Suggestion":
                    return "SELECT Id FROM Suggestion";
                case "Income":
                    return "SELECT ScheduleID FROM Schedule";
                case "Competition":
                    return "SELECT CompetitonID FROM Result";
                default:
                    throw new ArgumentException("Invalid command.");
            }
        }

        public void PopulateListBox(ListBox lbid, string command)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(GetQueryForCommand(command), con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<int> ids = new List<int>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        ids.Add(id);
                    }

                    lbid.DataSource = ids;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating list box: " + ex.Message);
            }
        }

        private string GetQueryForDetail(string command)
        {
            switch (command)
            {
                case "Suggestion":
                    return "SELECT Suggestion FROM Suggestion WHERE ID = @id";
                case "Income":
                    return "SELECT Income FROM Schedule WHERE ScheduleID = @id";
                case "Competition":
                    return "SELECT Result FROM Result WHERE CompetitionID = @id";
                default:
                    throw new ArgumentException("Invalid command.");
            }
        }

        public string GetSuggestionById(int id, string command)
        {
            string suggestion = "";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(GetQueryForDetail(command), con);
                    cmd.Parameters.AddWithValue("@id", id);
                    object suggestionObj = cmd.ExecuteScalar();

                    if (suggestionObj != null)
                    {
                        suggestion = suggestionObj.ToString();
                    }
                    else
                    {
                        suggestion = "No suggestion found for the selected ID.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return suggestion;
        }

    }
}