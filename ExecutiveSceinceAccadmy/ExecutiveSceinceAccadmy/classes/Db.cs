using ExecutiveSceinceAccadmy.classes;
using Microsoft.Data.SqlClient;  // Ensure this NuGet package is installed
using Microsoft.Identity.Client;
using System;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Web;      // For showing error messages temporarily
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ExecutiveSceinceAccadmy.classes
{
    public static class DB
    {

        private static string connectionString = "Server=CODEX\\SQLEXPRESS;Database=accadmyDb;Integrated Security=True;TrustServerCertificate=true;";
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;

        }
        public static void setConnectionStr(string conStr)
        {
            connectionString = conStr;
        }
        public static string getStr()
        {
            return connectionString;
        }
        // admin related functions and db operations
        public static bool Login(string username, string password)
        {



            using (SqlConnection con = new SqlConnection(connectionString))
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
        public static string createRegistrationNumber(string domain, string gender, string classLevel)
        {
            int currStd = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Insert a dummy row to get the next identity value
                // stdCountTB now must be IDENTITY-based    
                string query = "INSERT INTO stdCountTB DEFAULT VALUES; SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    currStd = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            string year = dataHandler.getLastTwoDigitOfYear(); // e.g., "26" for 2026

            // Registration format: YY-Class-Domain-Gender-Number
            return $"{year}-{classLevel}-{domain}-{gender}-{currStd}";
        }
        public static List<string> loadALlDomain()
        {
            List<string> domains = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
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
            string stdGender = std.Gender;
            string stdCNIC = std.Cnic;
            string stdPhoneNumber = std.PersonPhoneNumber;
            string stdDomainID = std.DomainName;
            string calssId = std.ClassLevel;
            string stdDob = std.DOB;
            string batchYear = dataHandler.getCurrentYear().ToString();
            string studentType = std.ReqisterType;

            string fatherName = father.Name;
            string fatherCNIC = father.Cnic;
            string fatherPhoneNumber = father.PersonPhoneNumber;
            string fatherJob = father.Job;

            string cityName = addr.City;
            string addressLine = addr.AddressLine;
            string country = addr.Country;

            string passingYear = academicHistory.PassingYear.ToString();
            string PreviousDegree = academicHistory.Degree;
            string PreviousSchoolName = academicHistory.SchoolName;
            string previousRegiestor = academicHistory.RegistrationNumber;
            string board = academicHistory.Board;
            int totalMarks = academicHistory.TotalMarks;
            int gainMarks = academicHistory.ObtainedMarks;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Convert class number
                    int classNum;
                    if (!int.TryParse(calssId, out classNum))
                        throw new Exception("Invalid class value.");

                    string className;

                    if (classNum <= 8)
                        className = classNum.ToString();
                    else
                        className = classNum + "th";

                    // Get REAL classId from classTb
                    int realClassId;

                    string classQuery = @"SELECT classId 
                              FROM classTb 
                              WHERE domainId = @domainId 
                              AND className = @className";

                    using (SqlCommand cmd = new SqlCommand(classQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@domainId", stdDomainID);
                        cmd.Parameters.AddWithValue("@className", className);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                            throw new Exception("Invalid class/domain combination.");

                        realClassId = Convert.ToInt32(result);
                    }

                    // Convert DOB
                    DateTime dateOfBirth;
                    if (!DateTime.TryParse(stdDob, out dateOfBirth))
                        throw new Exception("Invalid Date of Birth format.");

                    if (string.IsNullOrWhiteSpace(studentType))
                        studentType = "Regular";

                    // Insert student
                    string studentQuery = @"INSERT INTO StudentTb
                (stdRegisNo, student_name, domainId, classId, gender,
                 date_of_birth, cnic, father_name, father_cnic,
                 father_occupation, father_mobile_no, student_type, batchYear)
                VALUES
                (@registrationNo, @stdName, @domainId, @classId, @gender,
                 @date_of_birth, @cnic, @father_name, @father_cnic,
                 @father_occupation, @father_mobile_no, @student_type, @batchYear)";

                    using (SqlCommand cmd = new SqlCommand(studentQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@registrationNo", registrationNo);
                        cmd.Parameters.AddWithValue("@stdName", stdName);
                        cmd.Parameters.AddWithValue("@domainId", stdDomainID);
                        cmd.Parameters.AddWithValue("@classId", realClassId);
                        cmd.Parameters.AddWithValue("@gender", stdGender);
                        cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@cnic", stdCNIC);
                        cmd.Parameters.AddWithValue("@father_name", fatherName);
                        cmd.Parameters.AddWithValue("@father_cnic", fatherCNIC);
                        cmd.Parameters.AddWithValue("@father_occupation",
                            string.IsNullOrEmpty(fatherJob) ? (object)DBNull.Value : fatherJob);
                        cmd.Parameters.AddWithValue("@father_mobile_no", fatherPhoneNumber);
                        cmd.Parameters.AddWithValue("@student_type", studentType);
                        cmd.Parameters.AddWithValue("@batchYear", batchYear);

                        cmd.ExecuteNonQuery();
                    }

                    // Insert academic history
                    string query = @"INSERT INTO academicTb
            (stdRegisNo, previous_qualification, passingYear, registrationNo,
             previous_school_name, TotalMarks, gainMarks, board)
            VALUES
            (@stdRegisNo, @previous_qualification, @passingYear, @registrationNo,
             @previous_school_name, @TotalMarks, @gainMarks, @board)";

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

                    // Insert address
                    string query2 = @"INSERT INTO stdAdress
            (stdRegisNo, address, city, country)
            VALUES
            (@stdRegisNo, @address, @city, @country)";

                    using (SqlCommand cmd = new SqlCommand(query2, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@stdRegisNo", registrationNo);
                        cmd.Parameters.AddWithValue("@address", addressLine);
                        cmd.Parameters.AddWithValue("@city", cityName);
                        cmd.Parameters.AddWithValue("@country", country);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Student registered successfully! Registration No: " + registrationNo);
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Registration error: " + ex.Message);
                    return false;
                }
            }


}

        public static bool DisplayStudentDetailForFeeSubmission(string registrationNo, DataGridView dt)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT s.stdRegisNo, s.student_name, d.domainName, c.className, f.amount
                     FROM StudentTb s
                     JOIN domainTb d ON s.domainId = d.domainId
                     JOIN classTb c ON c.domainId = s.domainId
                         AND c.className = 
                             CASE 
                                 WHEN s.classId <= 8 THEN CAST(s.classId AS VARCHAR)
                                 ELSE CONCAT(s.classId,'th')
                             END
                     LEFT JOIN setStdFeeTb f ON f.domainId = c.domainId AND f.classId = c.classId
                     WHERE s.stdRegisNo = @RegNo;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RegNo", registrationNo);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dtTable = new DataTable();
                            da.Fill(dtTable);

                            dt.DataSource = dtTable;

                            // Header Renaming
                            if (dt.Columns.Contains("stdRegisNo"))
                                dt.Columns["stdRegisNo"].HeaderText = "Registration No";

                            if (dt.Columns.Contains("student_name"))
                                dt.Columns["student_name"].HeaderText = "Name";

                            if (dt.Columns.Contains("domainName"))
                                dt.Columns["domainName"].HeaderText = "Domain";

                            if (dt.Columns.Contains("className"))
                                dt.Columns["className"].HeaderText = "Class";

                            if (dt.Columns.Contains("amount"))
                                dt.Columns["amount"].HeaderText = "Fee Amount";

                            // ----------- UI Styling -----------

                            dt.BorderStyle = BorderStyle.None;
                            dt.RowHeadersVisible = false;
                            dt.EnableHeadersVisualStyles = false;

                            // Header style
                            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
                            dt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                            dt.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                            dt.ColumnHeadersHeight = 40;

                            // Row style
                            dt.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                            dt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dt.RowTemplate.Height = 35;

                            // Zebra rows
                            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

                            // Fill grid width evenly
                            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            // Selection color
                            dt.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
                            dt.DefaultCellStyle.SelectionForeColor = Color.White;

                            // Prevent messy resizing
                            dt.AllowUserToResizeRows = false;
                            dt.AllowUserToResizeColumns = false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool submitFee(string feeId, string registrationNo,
                              double amount,
                              double discountAmount,
                              string submittedBy,
                              string month,
                              int isPaid)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO feeTb
                            (feeId, stdRegisNo, paymentMonth, amount, discount, paidAmount, receivedBy, isPaid)
                             VALUES
                            (@feeId, @regNo, @month, @amount, @discount, @paidAmount, @receivedBy, @isPaid)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@feeId", feeId);
                        cmd.Parameters.AddWithValue("@regNo", registrationNo);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@discount", discountAmount);
                        cmd.Parameters.AddWithValue("@paidAmount", amount - discountAmount);
                        cmd.Parameters.AddWithValue("@receivedBy", submittedBy);
                        cmd.Parameters.AddWithValue("@isPaid", isPaid);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();

                        return rows > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("The student registration number does not exist in the database.",
                                    "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }
        }
        public static bool checkStudentFeeStatus(string registrationNumber, string month, string feeId, bool searchFlag, DataGridView feeGrid)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                s.student_name AS StudentName,
                                s.stdRegisNo AS RegistrationNo,
                                f.paymentMonth AS Month,
                                f.paymentDate AS PaymentDate,
                                f.paidAmount As NetPaidAmount,
                                CASE 
                                    WHEN f.isPaid = 1 THEN 'Paid'
                                    ELSE 'Not Paid'
                                END AS Status
                             FROM feeTb f
                             INNER JOIN StudentTb s
                                ON f.stdRegisNo = s.stdRegisNo ";

                    if (searchFlag)
                    {
                        query += "WHERE s.stdRegisNo = @regNo AND f.paymentMonth = @month";
                    }
                    else
                    {
                        query += "WHERE f.feeId = @feeId";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    if (searchFlag)
                    {
                        cmd.Parameters.AddWithValue("@regNo", registrationNumber);
                        cmd.Parameters.AddWithValue("@month", month);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@feeId", feeId);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    feeGrid.DataSource = dt;

                    return dt.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static string showTotalCollectionOfToday(string month)
        {
            string resultStr = "";
            string query = @"SELECT SUM(paidAmount) 
                     FROM feeTb 
                     WHERE CAST(paymentDate AS DATE) = @today 
                     AND paymentMonth = @month 
                     AND isPaid = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@today", DateTime.Today);
                    cmd.Parameters.AddWithValue("@month", month);

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        resultStr = Convert.ToDouble(result).ToString("0.00");
                    }
                    else
                    {
                        resultStr = "0";
                    }
                }
            }
            return resultStr;
        }
        public static string showTotalCollectionOfThisMonth(string month)
        {
            string resultStr = "";
            string query = @"SELECT SUM(paidAmount) 
                     FROM feeTb 
                     WHERE MONTH(paymentDate) = MONTH(GETDATE()) 
                     AND YEAR(paymentDate) = YEAR(GETDATE()) 
                     AND paymentMonth = @month
                     AND isPaid = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@month", month);

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        resultStr = Convert.ToDouble(result).ToString("0.00");
                    }
                    else
                    {
                        resultStr = "0";
                    }
                }

            }
            return resultStr;
        }
        public static string showTotalCollectionOfThisYear()
        {
            string resultStr = "0.00";

            string query = @"SELECT ISNULL(SUM(paidAmount),0) 
                     FROM feeTb 
                     WHERE YEAR(paymentDate) = YEAR(GETDATE()) 
                     AND isPaid = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                double result = Convert.ToDouble(cmd.ExecuteScalar());
                resultStr = result.ToString("0.00");
            }

            return resultStr;
        }
        public static void showDefaulterStudent(DataGridView dtDefaulter, string month)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                    s.student_name AS StudentName,
                    s.stdRegisNo AS RegistrationNo,
                    @month AS Month,
                    CASE 
                        WHEN f.isPaid = 1 THEN 'Paid'
                        ELSE 'Not Paid'
                    END AS Status
                 FROM StudentTb s
                 LEFT JOIN feeTb f 
                    ON s.stdRegisNo = f.stdRegisNo 
                    AND f.paymentMonth = @month
                 WHERE f.isPaid = 0 OR f.isPaid IS NULL";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@month", month);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtDefaulter.DataSource = dt;

                dtDefaulter.BorderStyle = BorderStyle.None;
                dtDefaulter.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dtDefaulter.EnableHeadersVisualStyles = false;
                dtDefaulter.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
                dtDefaulter.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dtDefaulter.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dtDefaulter.ColumnHeadersHeight = 40;
                dtDefaulter.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dtDefaulter.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 150, 255);
                dtDefaulter.DefaultCellStyle.SelectionForeColor = Color.White;
                dtDefaulter.RowTemplate.Height = 35;
                dtDefaulter.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                dtDefaulter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtDefaulter.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtDefaulter.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (DataGridViewRow row in dtDefaulter.Rows)
                {
                    if (row.Cells["Status"].Value != null)
                    {
                        if (row.Cells["Status"].Value.ToString() == "Not Paid")
                        {
                            row.Cells["Status"].Style.ForeColor = Color.Red;
                            row.Cells["Status"].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        }
                        else
                        {
                            row.Cells["Status"].Style.ForeColor = Color.Green;
                        }
                    }
                }
            }
        }
        public static string MapClassNumberToName(string classNumber)
        {
            int classNum;
            if (!int.TryParse(classNumber, out classNum))
                throw new Exception("Invalid class number.");

            if (classNum >= 1 && classNum <= 8)
                return classNum.ToString();
            else if (classNum >= 9 && classNum <= 12)
                return classNum + "th";
            else
                throw new Exception("Class number out of range (1-12).");
        }

        // ===================== Load Attendance =====================
        public static bool loadClassAttendance(string classSelectedNumber,
                                               string attendanceTypeSelected,
                                               DataGridView dtAttenddance)
        {
            try
            {
                string classSelected = MapClassNumberToName(classSelectedNumber);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT s.stdRegisNo, s.student_name
                             FROM StudentTb s
                             JOIN classTb c ON c.domainId = s.domainId
                             WHERE c.className = @className
                             AND s.student_type = @type
                             AND s.is_active = 1";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@className", classSelected);
                        cmd.Parameters.AddWithValue("@type", attendanceTypeSelected);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtAttenddance.Rows.Clear();
                        string today = DateTime.Now.ToString("dddd - dd/MM");

                        foreach (DataRow row in dt.Rows)
                        {
                            dtAttenddance.Rows.Add(
                                row["stdRegisNo"].ToString(),
                                row["student_name"].ToString(),
                                today,
                                true // default present
                            );
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
                return false;
            }
        }

        // ===================== Mark Attendance =====================
        public static bool MarkAttendanceByClassWise(List<AttendanceRecord> attendanceRecords, string givenClassNumber, string givenAttendanceType)
        {
            try
            {
                string givenClass = MapClassNumberToName(givenClassNumber);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    string query = @"INSERT INTO studentAttendance (attendId, stdRegisNo, isPresent, attenceType, day)
                             VALUES (@attendanceID, @stdRegisNo, @isPresent, @attendanceType, @day)";

                    foreach (var record in attendanceRecords)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@attendanceID", Guid.NewGuid().ToString("N")); // unique ID
                            cmd.Parameters.AddWithValue("@stdRegisNo", record.RegistrationNo);
                            cmd.Parameters.AddWithValue("@isPresent", record.IsPresent);
                            cmd.Parameters.AddWithValue("@attendanceType", record.AttendanceType);
                            cmd.Parameters.AddWithValue("@day", record.Day);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to mark attendance for {givenClassNumber} type {givenAttendanceType}.\nError: {ex.Message}");
                return false;
            }
        }

        public static bool showAttendacnceRecordOfDate(string studentRegistraionNo, string date, DataGridView dtDashAttend)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT 
                                s.student_name,
                                a.stdRegisNo,
                                a.isPresent,
                                a.attenceType,
                                a.day,
                                a.attendDate
                             FROM studentAttendance a
                             INNER JOIN StudentTb s
                             ON a.stdRegisNo = s.stdRegisNo
                             WHERE a.stdRegisNo = @regNo
                             AND a.attendDate = @date";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@regNo", studentRegistraionNo);
                    cmd.Parameters.AddWithValue("@date", date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtDashAttend.DataSource = dt;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool ShowAttendanceOfStudentOfMonth(string studentRegistraionNo, int month, DataGridView dtDashAttenddtDash)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT 
                                s.student_name,
                                a.stdRegisNo,
                                a.isPresent,
                                a.attenceType,
                                a.day,
                                a.attendDate
                             FROM studentAttendance a
                             INNER JOIN StudentTb s
                             ON a.stdRegisNo = s.stdRegisNo
                             WHERE a.stdRegisNo = @regNo
                             AND MONTH(a.attendDate) = @month";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@regNo", studentRegistraionNo);
                    cmd.Parameters.AddWithValue("@month", month);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtDashAttenddtDash.DataSource = dt;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool addFeeOfClassDomain(int classId, string domainId, int feeAmount)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 1️⃣ Check if fee already exists
                    string checkQuery = @"SELECT COUNT(*) 
                                  FROM setStdFeeTb 
                                  WHERE classId = @classId AND domainId = @domainId";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@classId", classId);
                        checkCmd.Parameters.AddWithValue("@domainId", domainId);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Fee already exists → ask admin
                            DialogResult result = MessageBox.Show(
                                "Fee already exists for this class and domain.\nDo you want to update it?",
                                "Update Fee",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // 2️⃣ Update fee
                                string updateQuery = @"UPDATE setStdFeeTb
                                               SET amount = @amount
                                               WHERE classId = @classId 
                                               AND domainId = @domainId";

                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("@amount", feeAmount);
                                    updateCmd.Parameters.AddWithValue("@classId", classId);
                                    updateCmd.Parameters.AddWithValue("@domainId", domainId);

                                    updateCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Fee updated successfully.");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Fee already added. No changes made.");
                                return false;
                            }
                        }
                        else
                        {
                            // 3️⃣ Insert new fee
                            string insertQuery = @"INSERT INTO setStdFeeTb (classId, domainId, amount)
                                           VALUES (@classId, @domainId, @amount)";

                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@classId", classId);
                                insertCmd.Parameters.AddWithValue("@domainId", domainId);
                                insertCmd.Parameters.AddWithValue("@amount", feeAmount);

                                insertCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Fee set successfully.");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding fee: " + ex.Message);
                return false;
            }
        }

        public static bool addExpense(string expenseId, string expenseType, double expenseAmount, string date, string expenseMonth)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO expenseTb 
                             (expenseId, expenseType, expenseAmount, expenseDate, expenseMonth)
                             VALUES 
                             (@expenseId, @expenseType, @expenseAmount, @expenseDate, @expenseMonth)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@expenseId", expenseId);
                        cmd.Parameters.AddWithValue("@expenseType", expenseType);
                        cmd.Parameters.AddWithValue("@expenseAmount", expenseAmount);
                        cmd.Parameters.AddWithValue("@expenseDate", Convert.ToDateTime(date));
                        cmd.Parameters.AddWithValue("@expenseMonth", expenseMonth);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            //MessageBox.Show("Expense added successfully!", "Success",
                            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Expense could not be added.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding expense: " + ex.Message);
                return false;
            }
        }
        public static bool expenseOfCurrentYearMonth(string year, string month, DataGridView dtExpense)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT expenseId, expenseType, expenseAmount, expenseDate, expenseMonth
                    FROM expenseTb
                    WHERE YEAR(expenseDate) = @year AND expenseMonth = @month
                    ORDER BY expenseDate";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@year", int.Parse(year));
                        cmd.Parameters.AddWithValue("@month", month);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtExpense.DataSource = dt;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expenses: " + ex.Message);
                return false;
            }
        }

        public static bool LoadExpenseOfYear(string year, DataGridView dtExpense)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT expenseId, expenseType, expenseAmount, expenseDate, expenseMonth
                    FROM expenseTb
                    WHERE YEAR(expenseDate) = @year
                    ORDER BY expenseDate";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@year", int.Parse(year));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtExpense.DataSource = dt;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expenses: " + ex.Message);
                return false;
            }
        }
        public static bool laodSujectAndClassToTeacherHiring(DataGridView dt)
        {
            try
            {
                //string connectionString = @"Your_Connection_String_Here";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Corrected query using SubjectPack for subject names
                    string query = @"
                SELECT 
                    c.className,
                    sp.subjectName,
                    s.classId,
                    s.subjectId,
                    s.domainId
                FROM subjectTb s
                INNER JOIN SubjectPack sp ON s.subjectId = sp.subjectId
                INNER JOIN classTb c ON s.classId = c.classId
                ORDER BY s.domainId, s.classId, s.subjectId
            ";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);

                    dt.DataSource = dtbl;

                    // Add a checkbox column for selection
                    if (!dt.Columns.Contains("Select"))
                    {
                        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                        chk.HeaderText = "Select";
                        chk.Name = "Select";
                        dt.Columns.Insert(0, chk); // Insert checkbox as first column
                    }

                    // Move classId and subjectId to the end
                    dt.Columns["classId"].DisplayIndex = dt.Columns.Count - 2;
                    dt.Columns["subjectId"].DisplayIndex = dt.Columns.Count - 1;

                    dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                return false;
            }
        }
        public static bool HireTeacher(TeacherData data, DataGridView dtSubjects)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            // 1️⃣ Insert teacher info
                            string insertTeacher = @"
                        INSERT INTO teacherTb
                        (teacherId, teacherName, teacherQualification, fatherName, fatherCnic, teacherCnic)
                        VALUES
                        (@teacherId, @teacherName, @qualification, @fatherName, @fatherCNIC, @teacherCnic)";
                            using (SqlCommand cmd = new SqlCommand(insertTeacher, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@teacherId", data.TeacherId);
                                cmd.Parameters.AddWithValue("@teacherName", data.TeacherName);
                                cmd.Parameters.AddWithValue("@qualification", data.Qualification);
                                cmd.Parameters.AddWithValue("@fatherName", data.FatherName);
                                cmd.Parameters.AddWithValue("@fatherCNIC", data.FatherCNIC);
                                cmd.Parameters.AddWithValue("@teacherCnic", data.TeacherCnic);
                                cmd.ExecuteNonQuery();
                            }

                            // 2️⃣ Insert teacher address
                            string insertAddress = @"
                        INSERT INTO teacherAddTb
                        (teacherId, address, city, country)
                        VALUES
                        (@teacherId, @address, @city, @country)";
                            using (SqlCommand cmd = new SqlCommand(insertAddress, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@teacherId", data.TeacherId);
                                cmd.Parameters.AddWithValue("@address", data.Address);
                                cmd.Parameters.AddWithValue("@city", data.AddressCity);
                                cmd.Parameters.AddWithValue("@country", data.AddressCountry);
                                cmd.ExecuteNonQuery();
                            }

                            // 3️⃣ Insert payment info
                            string insertPayment = @"
                        INSERT INTO teacherPaymentTb
                        (teacherId, teacherType, salary, percentage)
                        VALUES
                        (@teacherId, @teacherType, @salary, @percentage)";
                            using (SqlCommand cmd = new SqlCommand(insertPayment, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@teacherId", data.TeacherId);
                                cmd.Parameters.AddWithValue("@teacherType", data.TeacherType);
                                cmd.Parameters.AddWithValue("@salary", string.IsNullOrEmpty(data.Salary) ? 0 : decimal.Parse(data.Salary));
                                cmd.Parameters.AddWithValue("@percentage", string.IsNullOrEmpty(data.Percentage) ? 0 : decimal.Parse(data.Percentage));
                                cmd.ExecuteNonQuery();
                            }

                            // 4️⃣ Assign subjects from DataGridView
                            string insertSubject = @"
                        INSERT INTO teacherClassSubjectTb
                        (teacherId, classId, subjectId, domainId)
                        VALUES (@teacherId, @classId, @subjectId, @domainId)";
                            using (SqlCommand cmd = new SqlCommand(insertSubject, con, tran))
                            {
                                foreach (DataGridViewRow row in dtSubjects.Rows)
                                {
                                    if (row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value)
                                    {
                                        cmd.Parameters.Clear();
                                        cmd.Parameters.AddWithValue("@teacherId", data.TeacherId);
                                        cmd.Parameters.AddWithValue("@classId", Convert.ToInt32(row.Cells["classId"].Value));
                                        cmd.Parameters.AddWithValue("@subjectId", Convert.ToInt32(row.Cells["subjectId"].Value));
                                        cmd.Parameters.AddWithValue("@domainId", row.Cells["domainId"].Value.ToString());
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            tran.Commit();
                            return true;
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error hiring teacher: " + ex.Message);
                return false;
            }
        }




    }
}
