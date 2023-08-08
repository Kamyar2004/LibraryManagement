using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement2023
{
    class Database : IDatabase
    {
        private string connectionString = "Data Source=.;Initial Catalog=LibraryManagement_DB;Integrated Security=True";
        public SqlDataAdapter adapter;

        public Database()
        {
            adapter = new SqlDataAdapter();
        }

        public void dbConnection(string query, out SqlConnection connection, out SqlCommand command)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(query, connection);
        }

        public DataRow selectRow(string tableName, string columnName, string value)
        {
            dbConnection("select * from " + tableName + " where " + columnName + "=@" + columnName, out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@" + columnName, value);
            adapter.SelectCommand = command;
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataRow row = data.Rows[0];
            connection.Close();
            return row;
        }

        public int countRow(string tableName, string columnName, string value)
        {
            dbConnection("select count(*) from " + tableName + " where " + columnName + "=@" + columnName, out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@" + columnName, value);
            adapter.SelectCommand = command;
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataRow row = data.Rows[0];
            int count = Convert.ToInt32(row[0]);
            connection.Close();
            return count;
        }

        public void deleteRow(string tableName, string columnName, string value)
        {
            dbConnection("delete from " + tableName + " where " + columnName + "=@" + columnName, out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@" + columnName, value);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable selectAll(string tableName, string columnId)
        {
            dbConnection("select * from " + tableName + " order by " + columnId + " desc", out SqlConnection connection, out SqlCommand command);
            adapter.SelectCommand = command;
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}
