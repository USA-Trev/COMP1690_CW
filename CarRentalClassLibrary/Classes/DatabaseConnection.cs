using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary.Classes
{
    public class DatabaseConnection
    {
        private string connectionString = "Data Source=DESKTOP-TREVORE\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True";
        private SqlConnection conn;

        // Open connection to database
        public void Open()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        // Close connection to database
        public void Close()
        {
            conn.Close();
        }

        // Executes queries -- INSERT, UPDATE, DELETE, etc.
        public void ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        // Count number of rows returned by a query
        public int CountRows(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int rowsReturned = dt.Rows[0].Field<int>("Count");
            return rowsReturned;
        }

        // Return datatable containing the results from a query
        public DataTable OutputResults(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
    }
}
