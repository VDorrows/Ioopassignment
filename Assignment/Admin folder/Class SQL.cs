using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Assignment
{
    public class SqlHelper
    {
        private readonly string connectionString;
        private SqlConnection connection;

        public SqlHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private SqlCommand Command(string query, Dictionary<string, object> parameters)
        {
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            }
            return command;
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            SqlCommand command = Command(query, parameters);

            try
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            SqlCommand command = Command(query, parameters);

            try
            {
                connection.Open();
                return command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            SqlCommand command = Command(query, parameters);

            try
            {
                connection.Open();
                return command.ExecuteScalar();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}