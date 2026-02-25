using System;
using System.Data;
using Microsoft.Data.SqlClient;  // Ensure this NuGet package is installed
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Web;      // For showing error messages temporarily

namespace ExecutiveSceinceAccadmy.classes
{
    public static class DB
    {

        private static string str = "Server=CODEX\\SQLEXPRESS;Database=accadmyDb;Integrated Security=True;TrustServerCertificate=true;";
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
        // admin related functions and db operations
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
        // strudent methods here, such as methods for adding students, retrieving data, etc.
        public static int getCurrentStdNumber()
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                string query = "select stdCount from stdCountTB";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    int currentStd = (int)cmd.ExecuteScalar();
                    MessageBox.Show("Current Student Number: " + currentStd);
                    return currentStd;
                }
            }
        }
        public static void updateCurrentStdNumber(int newStdNumber)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
               string query = "update stdCountTB set stdCount = @newStdNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@newStdNumber", SqlDbType.Int).Value = newStdNumber;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Number Updated to: " + newStdNumber);
                }
            }
        }
     public static List<string>  loadALlDomain()
        {
            List<string> domains = new List<string>();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                string query = "select domainId from domainTb";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            domains.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return domains;
        }
        //very importatnt method for registering a student, it will take a student object and insert all the data into the database, including the address, academic history, and father information. this method will be called from the student registration form when the user clicks the register button.
        //public static void registerStudent(Student std, string registrationNo)
        //{
        //    Address addr = std.Address;
        //    Father father = std.Father;
        //    accadmicHistory academicHistory = std.AcademicHistories;
        //    string stdName = std.Name;
        //    int stdAge = std.Age;
        //    string stdGender = std.Gender;
        //    string stdCNIC = std.Cnic;
        //    string stdPhoneNumber = std.PersonPhoneNumber;
        //    string batchYear = dataHandle.getCurrentYear().ToString();
        //    //father info
        //    string fatherName = father.Name;
        //    string fatherCNIC = father.Cnic;
        //    string fatherPhoneNumber = father.PersonPhoneNumber;
        //    string fatherJob = father.Job;
        //    //address info
        //    string cityName = addr.City;
        //    string addressLine = addr.AddressLine;
        //    string country = addr.Country;
        //    //academic history info
        //    string passingYear = academicHistory.PassingYear.ToString();
        //    string PreviousDegree = academicHistory.Degree;
        //    string PreviousSchoolName = academicHistory.SchoolName;
        //    string previousRegiestor = academicHistory.RegistrationNumber;
        //    string board = academicHistory.Board;
        //    int totalMarks = academicHistory.TotalMarks;
        //    int gainMarks = academicHistory.ObtainedMarks;

        //    //db logic
        //    using (SqlConnection con = new SqlConnection(str))
        //    {
        //        con.Open();
        //        string query = "INSERT INTO studentTb (stdRegisNo, student_name, domainId, classId, gender, date_of_birth, cnic, father_name, father_cnic, father_occupation, father_mobile_no, student_type, batchYear)" +
        //                       "VALUES (@stdRegisNo, @student_name, @domainId, @classId, @gender, @date_of_birth, @cnic, @father_name, @father_cnic, @father_occupation, @father_mobile_no, @student_type, @batchYear)";







        //    }
        //}
    }
}