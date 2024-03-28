using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Assignment
{
    public class SqlHelper
    {
        private readonly string connectionString;
        private SqlConnection con;
        private SqlCommand command;
        private SqlTransaction transaction;

        public SqlHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            con = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = con;
            transaction = null;
        }

        public SqlTransaction beginTransaction()
        {
            transaction = con.BeginTransaction();
            command.Transaction = transaction;
            return transaction;
        }

        public void openCon() //Manually opens connection when required
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void closeCon() //Manually closes the connection when required
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        public DataTable executeQuery(string query, Dictionary<string, object> parameters = null)
        {
            openCon();

            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = query;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
        }

        public object executeScalar(string query, Dictionary<string, object> parameters = null)
        {
            openCon();

            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = query;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                return command.ExecuteScalar();
            }
        }

        public void addData(string tableName, Dictionary<string, object> data, SqlTransaction transaction)
        {
            try
            {
                // Construct the SQL query
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append($"INSERT INTO {tableName} (");

                // Add column names to the query
                foreach (var column in data.Keys)
                {
                    queryBuilder.Append($"{column}, ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2); // Remove the last comma and space
                queryBuilder.Append(") VALUES (");

                // Add parameter placeholders to the query
                foreach (var column in data.Keys)
                {
                    queryBuilder.Append($"@{column}, ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2);
                queryBuilder.Append(")");

                string query = queryBuilder.ToString();

                // Execute the query with transaction
                using (SqlCommand command = transaction.Connection.CreateCommand())
                {
                    command.Transaction = transaction;
                    command.CommandText = query;

                    // Add parameters to the command
                    foreach (var entry in data)
                    {
                        command.Parameters.AddWithValue($"@{entry.Key}", entry.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding data to the table {tableName}: {ex.Message}");
            }
        }

        public void editData(string tableName, string keyColumn, object keyValue, Dictionary<string, object> newData, SqlTransaction transaction)
        {
            try
            {

                // Construct the SQL query
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append($"UPDATE {tableName} SET ");

                // Add new values to update
                foreach (var entry in newData)
                {
                    queryBuilder.Append($"{entry.Key} = @{entry.Key}, ");
                }
                queryBuilder.Remove(queryBuilder.Length - 2, 2); // Remove the last comma and space

                // Add condition for updating specific row
                queryBuilder.Append($" WHERE {keyColumn} = @{keyColumn}");

                string query = queryBuilder.ToString();

                // Execute the query
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = query;
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }

                    // Add parameters to the command
                    foreach (var entry in newData)
                    {
                        command.Parameters.AddWithValue($"@{entry.Key}", entry.Value);
                    }
                    command.Parameters.AddWithValue($"@{keyColumn}", keyValue);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating data in the table {tableName}: {ex.Message}");
            }

        }

        public void deleteData(string tableName, string condition, Dictionary<string, object> parameters, SqlTransaction transaction)
        {
            try
            {
                
                // Construct the SQL query
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append($"DELETE FROM {tableName}");

                // Add condition to the query
                if (!string.IsNullOrEmpty(condition))
                {
                    queryBuilder.Append($" WHERE {condition}");
                }

                string query = queryBuilder.ToString();

                // Execute the query
                using (SqlCommand command = con.CreateCommand())
                {
                    command.Transaction = transaction;
                    command.CommandText = query;

                    // Add parameters to the command
                    foreach (var entry in parameters)
                    {
                        command.Parameters.AddWithValue(entry.Key, entry.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting data from the table {tableName}: {ex.Message}");
            }
        }
    }
}