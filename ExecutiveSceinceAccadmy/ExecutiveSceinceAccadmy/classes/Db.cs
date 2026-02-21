using System;
using System.Data;
using Microsoft.Data.SqlClient;  // Ensure this NuGet package is installed
using System.Windows.Forms;
using System.Runtime.CompilerServices;      // For showing error messages temporarily

namespace ExecutiveSceinceAccadmy.classes
{
    public static class DB
    {
        
        private static  string str = "Server=CODEX\\SQLEXPRESS;Database=accadmyDb;Integrated Security=True;TrustServerCertificate=true;";
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
            
        }
        public static void setConnectionStr(string conStr)
        {
            str = conStr;
        }
        public static string getStr()
        {
            return str;
        }
        public static bool Login(string username, string password)
        {
           
          

            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM adminTb WHERE userName = @u AND password = @p";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                       
                        cmd.Parameters.Add("@u", SqlDbType.VarChar, 20).Value = username;
                        cmd.Parameters.Add("@p", SqlDbType.VarChar, 20).Value = password;

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}