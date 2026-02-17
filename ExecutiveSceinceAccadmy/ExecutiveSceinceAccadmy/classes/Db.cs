//using System;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace ExecutiveSceinceAccadmy.classes
//{
//    internal class Db
//    {
//        private static string connectionString =
//            @"Data Source=HABIBSYSTEM\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";

//        public static SqlConnection CreateConnection()
//        {
//            SqlConnection con = new SqlConnection(connectionString);

//            try
//            {
//                con.Open();
//                MessageBox.Show("Connected Successfully");
//                return con;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Connectivity Error: " + ex.Message);
//                return null;   // Important fix
//            }
//        }

//        public static SqlCommand GetCommand(string query, SqlConnection con)
//        {
//            if (con == null)
//            {
//                MessageBox.Show("Connection is not available.");
//                return null;
//            }

//            return new SqlCommand(query, con);
//        }
//    }
//}
