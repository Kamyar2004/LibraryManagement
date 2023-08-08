using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagement2023
{
    interface IDatabase
    {
        void dbConnection(string query, out SqlConnection connection, out SqlCommand command);
        DataRow selectRow(string tableName, string columnName, string value);
        int countRow(string tableName, string columnName, string value);
        void deleteRow(string tableName, string columnName, string value);
        DataTable selectAll(string tableName, string columnId);
    }
}
