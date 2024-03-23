using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment
{
    public partial class View_Suggestion : Form
    {
        private readonly string connectionString;
        public View_Suggestion()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            PopulateListBox();
        }
        private void PopulateListBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Id FROM Suggestion", con);
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

        private void lbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected ID from the list box
                int selectedId = Convert.ToInt32(lbid.SelectedItem);

                // Retrieve the suggestion from the database based on the selected ID
                string suggestion = GetSuggestionById(selectedId);

                // Display the suggestion in the read-only text box
                rtbsuggestion.Text = suggestion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetSuggestionById(int id)
        {
            string suggestion = "";

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Suggestion FROM Suggestion WHERE ID = @id", con);
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
