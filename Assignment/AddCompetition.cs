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
    public partial class frmComAdd : Form
    {
        public frmComAdd()
        {
            InitializeComponent();
        }

        private void btnAddCom_Click(object sender, EventArgs e)
        {
  

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Competition"].ToString()))
            {
                
                try
                {
                    // Data validation
                    if (!DateTime.TryParse(txtComDate.Text, out DateTime date))
                    {
                        MessageBox.Show("Invalid date format.");
                        return;
                    }

                    string query = "INSERT INTO competition (Name, Date, Location, Description) VALUES (@Name, @Date, @Location, @Description)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtComName.Text);
                        command.Parameters.AddWithValue("@Date", date); // Use parsed DateTime
                        command.Parameters.AddWithValue("@Location", txtComLocation.Text);
                        command.Parameters.AddWithValue("@Description", txtComDescription.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    // Log the exception or handle it appropriately
                }
            }




        }
    }
}
