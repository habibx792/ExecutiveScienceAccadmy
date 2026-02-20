using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ExecutiveSceinceAccadmy.classes
{
    public static class DB
    {
        private static string str = @"Data Source=CODEX\SQLEXPRESS;Initial Catalog=accadmyDb;Integrated Security=True";

        public static SqlConnection CreateConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(str);
                con.Open();
                return con;
            }
            catch (SqlException)
            {
                return null;   // connection failed
            }
        }

        // ---------- Admin Methods ----------

        public static bool Login(string username, string password)
        {
            using (SqlConnection con = CreateConnection())
            {
                if (con == null) return false;   // connection failed

                string query = "SELECT COUNT(*) FROM adminTb WHERE userName = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static void Register(string cnic, string username, string password)
        {
            using (SqlConnection con = CreateConnection())
            {
                if (con == null)
                {
                    MessageBox.Show("Database connection failed.");
                    return;
                }

                string query = "INSERT INTO adminTb (adminCnic, userName, password) VALUES (@cnic, @username, @password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cnic", cnic);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Registration successful!" : "Registration failed.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
            }
        }

        public static void UpdateAdminPassword(string username, string newPassword)
        {
            using (SqlConnection con = CreateConnection())
            {
                if (con == null)
                {
                    MessageBox.Show("Database connection failed.");
                    return;
                }

                string query = "UPDATE adminTb SET password = @newPassword WHERE userName = @username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Password updated!" : "Username not found.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
            }
        }

        public static void DeleteAdmin(string username)
        {
            using (SqlConnection con = CreateConnection())
            {
                if (con == null)
                {
                    MessageBox.Show("Database connection failed.");
                    return;
                }

                string query = "DELETE FROM adminTb WHERE userName = @username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Admin deleted." : "Username not found.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
            }
        }
    }
}