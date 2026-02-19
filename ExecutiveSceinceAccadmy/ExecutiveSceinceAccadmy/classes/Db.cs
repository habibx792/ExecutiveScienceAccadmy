using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ExecutiveSceinceAccadmy.classes
{
    internal sealed class DB
    {
        private static readonly DB instance = new DB();

        private static string str = @"Data Source=HABIBSYSTEM\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";

        private DB() { }

        public static DB Instance
        {
            get { return instance; }
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                MessageBox.Show("Connected");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Connectivity error: {ex.Message}");
            }
            return con;
        }
        public void setConnectionString(string newConnectionString)
        {
            if (!string.IsNullOrEmpty(newConnectionString))
            {
                str = newConnectionString;
            }
            else
            {
                MessageBox.Show("Invalid connection string.");
            }
        }
        public string getConnectionString()
        {
            return str;
        }
        public SqlCommand GetCommand(string query, SqlConnection con)
        {
            return new SqlCommand(query, con);
        }
    }
}
