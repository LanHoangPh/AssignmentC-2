using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_2
{
    internal class Data
    {
        private SqlConnection _connection;

        public Data()
        {
            string connectionString = @"Data Source=DESKTOP-G1OA6S5\HOANGLAN;Initial Catalog=Hocsinh;Integrated Security=True;Trust Server Certificate=True";
            _connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public SqlCommand CreateCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command;
        }
    }
}
