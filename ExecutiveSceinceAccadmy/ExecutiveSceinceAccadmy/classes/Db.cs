using Microsoft.Data.SqlClient;  // Ensure this NuGet package is installed
using System;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Web;      // For showing error messages temporarily
using System.Windows.Forms;
using ExecutiveSceinceAccadmy.classes;
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
        //very importatnt method for registering a student, it will take a student object and insert all the data into the database, including the address, academic history, and father information.this method will be called from the student registration form when the user clicks the register button.
        internal static bool registerAStudent(Student std, string registrationNo)
        {
            Address addr = std.Address;
            Father father = std.Father;
            accadmicHistory academicHistory = std.AcademicHistories;
            string stdName = std.Name;
            int stdAge = std.Age;
            string stdGender = std.Gender;
            string stdCNIC = std.Cnic;
            string stdPhoneNumber = std.PersonPhoneNumber;
            string stdDomainID = std.DomainName;
            string calssId = std.ClassLevel;
            string stdDob = std.DOB;
            string batchYear = dataHandle.getCurrentYear().ToString();
            string studentType = std.ReqisterType;
            //father info
            string fatherName = father.Name;
            string fatherCNIC = father.Cnic;
            string fatherPhoneNumber = father.PersonPhoneNumber;
            string fatherJob = father.Job;
            //address info
            string cityName = addr.City;
            string addressLine = addr.AddressLine;
            string country = addr.Country;
            //academic history info
            string passingYear = academicHistory.PassingYear.ToString();
            string PreviousDegree = academicHistory.Degree;
            string PreviousSchoolName = academicHistory.SchoolName;
            string previousRegiestor = academicHistory.RegistrationNumber;
            string board = academicHistory.Board;
            int totalMarks = academicHistory.TotalMarks;
            int gainMarks = academicHistory.ObtainedMarks;

            //we have to put data in three table StudentTb academicTb stdAdress 
            using
                (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    // FIX: Convert classId to int since database expects INT
                    int classIdInt;
                    if (!int.TryParse(calssId, out classIdInt))
                    {
                        throw new Exception("Invalid Class Level format. Please enter a valid number.");
                    }

                    // FIX: Convert date string to DateTime for proper SQL DATE format
                    DateTime dateOfBirth;
                    if (!DateTime.TryParse(stdDob, out dateOfBirth))
                    {
                        throw new Exception("Invalid Date of Birth format. Please use yyyy-MM-dd.");
                    }

                    // FIX: Ensure student type has a default value
                    if (string.IsNullOrWhiteSpace(studentType))
                        studentType = "Regular";

                    string studentQuery = @"INSERT INTO StudentTb (
                                            stdRegisNo,
                                            student_name,
                                            domainId,
                                            classId,
                                            gender,
                                            date_of_birth,
                                            cnic,
                                            father_name,
                                            father_cnic,
                                            father_occupation,
                                            father_mobile_no,
                                            student_type,
                                            batchYear
                                        )
                                        VALUES (
                                            @registrationNo,
                                            @stdName,
                                            @domainId,
                                            @classId,
                                            @gender,
                                            @date_of_birth,
                                            @cnic,
                                            @father_name,
                                            @father_cnic,
                                            @father_occupation,
                                            @father_mobile_no,
                                            @student_type,
                                            @batchYear
                                        );";
                    using (SqlCommand cmd = new SqlCommand(studentQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@registrationNo", registrationNo);
                        cmd.Parameters.AddWithValue("@stdName", stdName);
                        cmd.Parameters.AddWithValue("@domainId", stdDomainID);
                        cmd.Parameters.AddWithValue("@classId", classIdInt); // FIX: Using converted int value
                        cmd.Parameters.AddWithValue("@gender", stdGender);
                        cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth); // FIX: Using DateTime object
                        cmd.Parameters.AddWithValue("@cnic", stdCNIC);
                        cmd.Parameters.AddWithValue("@father_name", fatherName);
                        cmd.Parameters.AddWithValue("@father_cnic", fatherCNIC);
                        cmd.Parameters.AddWithValue("@father_occupation", string.IsNullOrEmpty(fatherJob) ? (object)DBNull.Value : fatherJob);
                        cmd.Parameters.AddWithValue("@father_mobile_no", fatherPhoneNumber);
                        cmd.Parameters.AddWithValue("@student_type", studentType);
                        cmd.Parameters.AddWithValue("@batchYear", batchYear);

                        cmd.ExecuteNonQuery();
                    }

                    // FIX: Fixed column order in query - parameters must match VALUES order
                    string query = @"Insert into academicTb(stdRegisNo, previous_qualification, passingYear, registrationNo, previous_school_name, TotalMarks, gainMarks, board)
                        VALUES(@stdRegisNo, @previous_qualification, @passingYear, @registrationNo, @previous_school_name, @TotalMarks, @gainMarks, @board);";
                    using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@stdRegisNo", registrationNo);
                        cmd.Parameters.AddWithValue("@previous_qualification", PreviousDegree);
                        cmd.Parameters.AddWithValue("@passingYear", passingYear);
                        cmd.Parameters.AddWithValue("@registrationNo", previousRegiestor);
                        cmd.Parameters.AddWithValue("@previous_school_name", PreviousSchoolName);
                        cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
                        cmd.Parameters.AddWithValue("@gainMarks", gainMarks);
                        cmd.Parameters.AddWithValue("@board", board);
                        cmd.ExecuteNonQuery();

                    }

                    // FIX: Fixed parameter order - @city and @address were swapped in VALUES
                    string query2 = @"Insert into stdAdress(stdRegisNo, address, city, country)
                        VALUES(@stdRegisNo, @address, @city, @country);";
                    using (SqlCommand cmd = new SqlCommand(query2, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@stdRegisNo", registrationNo);
                        cmd.Parameters.AddWithValue("@address", addressLine);
                        cmd.Parameters.AddWithValue("@city", cityName);
                        cmd.Parameters.AddWithValue("@country", country);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("Student registered successfully! Registration No: " + registrationNo, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public static void DisplayStudentDetailForFeeSubmission(string registrationNo, DataGridView dt)
        {
            // Replace with your actual connection string
            //string str = "your_connection_string_here";

            using (SqlConnection con = new SqlConnection(str))
            {
                string query = @"
            SELECT 
                s.stdRegisNo,
                s.student_name,
                d.domainName,
                c.className,
                f.amount
            FROM StudentTb s
            JOIN domainTb d
                ON s.domainId = d.domainId
            JOIN classTb c
                ON c.domainId = s.domainId
                AND c.className =
                    CASE 
                        WHEN s.classId <= 8 THEN CAST(s.classId AS VARCHAR)
                        ELSE CONCAT(s.classId,'th')
                    END
            LEFT JOIN setStdFeeTb f
                ON f.domainId = c.domainId
                AND f.classId = c.classId
            WHERE s.stdRegisNo = @RegNo;
        ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@RegNo", registrationNo);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dtTable = new DataTable();
                        da.Fill(dtTable);  // Fill DataTable with query results

                        // Bind DataTable to DataGridView
                        dt.DataSource = dtTable;

                        // Optional: Set column headers
                        if (dt.Columns.Contains("stdRegisNo")) dt.Columns["stdRegisNo"].HeaderText = "Registration No";
                        if (dt.Columns.Contains("student_name")) dt.Columns["student_name"].HeaderText = "Name";
                        if (dt.Columns.Contains("domainName")) dt.Columns["domainName"].HeaderText = "Domain";
                        if (dt.Columns.Contains("className")) dt.Columns["className"].HeaderText = "Class";
                        if (dt.Columns.Contains("amount")) dt.Columns["amount"].HeaderText = "Fee Amount";
                    }
                }
            }
        }
    }
}