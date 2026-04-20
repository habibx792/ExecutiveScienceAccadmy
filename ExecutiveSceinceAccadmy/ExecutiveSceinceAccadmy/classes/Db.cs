using ExecutiveSceinceAccadmy.classes;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExecutiveSceinceAccadmy.classes
{
    public static class DB
    {
        private static string connectionString = "Server=CODEX\\SQLEXPRESS;Database=accadmyDb;Integrated Security=True;TrustServerCertificate=true;";

        // ========================== 1. CONNECTION & UTILITY ==========================
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

        // ========================== 2. LOGIN / AUTHENTICATION ==========================
        public static bool createStudentLogin(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO studentPassword(stdRegisNo, password)
                             VALUES(@username, @password)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating student login: " + ex.Message);
                return false;
            }
        }

        public static bool createTeacherLogin(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO teacherPassword(teacherId, password)
                             VALUES(@username, @password)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating teacher login: " + ex.Message);
                return false;
            }
        }

        public static bool loginStudent(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT COUNT(1) 
                             FROM studentPassword 
                             WHERE stdRegisNo = @username 
                             AND password = @password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
                return false;
            }
        }

        public static bool loginTeacher(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT COUNT(1) 
                             FROM teacherPassword 
                             WHERE teacherId = @username 
                             AND password = @password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
                return false;
            }
        }

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

        // ========================== 3. STUDENT REGISTRATION ==========================
        public static string createRegistrationNumber(string domain, string gender, string classLevel)
        {
            int currStd = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

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

        // ========================== 4. FEE MANAGEMENT ==========================
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

                            // UI Styling
                            dt.BorderStyle = BorderStyle.None;
                            dt.RowHeadersVisible = false;
                            dt.EnableHeadersVisualStyles = false;

                            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
                            dt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                            dt.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                            dt.ColumnHeadersHeight = 40;

                            dt.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                            dt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dt.RowTemplate.Height = 35;
                            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dt.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
                            dt.DefaultCellStyle.SelectionForeColor = Color.White;
                            dt.AllowUserToResizeRows = false;
                            dt.AllowUserToResizeColumns = false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // ========================== 5. ATTENDANCE (STUDENT & TEACHER) ==========================
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
                            cmd.Parameters.AddWithValue("@attendanceID", Guid.NewGuid().ToString("N"));
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

        // Teacher Attendance
        public static List<string> GetAllTeacherNames()
        {
            List<string> teacherNames = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT teacherName FROM teacherTb WHERE is_active = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["teacherName"].ToString();
                            teacherNames.Add(name);
                        }
                    }
                }
            }

            return teacherNames;
        }

        public static bool markTeacherAttendance(string teacherId, bool isArrival, DateTime attendDate, DateTime attendTime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        string checkQuery = @"SELECT arrivalTime, departureTime 
                                      FROM teacherAttendance 
                                      WHERE teacherId = @teacherId AND attendDate = @date";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@teacherId", teacherId);
                            checkCmd.Parameters.AddWithValue("@date", attendDate.Date);

                            using (SqlDataReader reader = checkCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    DateTime? existingArrival = reader["arrivalTime"] as DateTime?;
                                    DateTime? existingDeparture = reader["departureTime"] as DateTime?;
                                    reader.Close();

                                    if (isArrival)
                                    {
                                        if (existingArrival == null)
                                        {
                                            string updateArrival = @"UPDATE teacherAttendance
                                                             SET arrivalTime = @time, isPresent = 1
                                                             WHERE teacherId = @teacherId AND attendDate = @date";
                                            using (SqlCommand cmd = new SqlCommand(updateArrival, conn, transaction))
                                            {
                                                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                                                cmd.Parameters.AddWithValue("@time", attendTime);
                                                cmd.Parameters.AddWithValue("@date", attendDate.Date);
                                                cmd.ExecuteNonQuery();
                                            }
                                            transaction.Commit();
                                            return true;
                                        }
                                        else
                                        {
                                            transaction.Rollback();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        if (existingArrival == null)
                                        {
                                            transaction.Rollback();
                                            return false;
                                        }
                                        if (existingDeparture != null)
                                        {
                                            transaction.Rollback();
                                            return false;
                                        }
                                        if (attendTime < existingArrival.Value.AddHours(1))
                                        {
                                            transaction.Rollback();
                                            return false;
                                        }

                                        string updateDeparture = @"UPDATE teacherAttendance
                                                           SET departureTime = @time
                                                           WHERE teacherId = @teacherId AND attendDate = @date";
                                        using (SqlCommand cmd = new SqlCommand(updateDeparture, conn, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@teacherId", teacherId);
                                            cmd.Parameters.AddWithValue("@time", attendTime);
                                            cmd.Parameters.AddWithValue("@date", attendDate.Date);
                                            cmd.ExecuteNonQuery();
                                        }
                                        transaction.Commit();
                                        return true;
                                    }
                                }
                                else
                                {
                                    reader.Close();

                                    if (isArrival)
                                    {
                                        string insertQuery = @"INSERT INTO teacherAttendance (teacherId, attendDate, arrivalTime, isPresent) 
                                                       VALUES (@teacherId, @date, @time, 1)";
                                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                                        {
                                            insertCmd.Parameters.AddWithValue("@teacherId", teacherId);
                                            insertCmd.Parameters.AddWithValue("@date", attendDate.Date);
                                            insertCmd.Parameters.AddWithValue("@time", attendTime);
                                            insertCmd.ExecuteNonQuery();
                                        }
                                        transaction.Commit();
                                        return true;
                                    }
                                    else
                                    {
                                        transaction.Rollback();
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
        }
        // Add/modify this method in your DB class
        public static bool loadTeacherAttendanceRecord(string teacherId, int month, DataGridView dtAttend)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                        t.teacherName,
                        a.attendDate,
                        a.arrivalTime,
                        a.departureTime,
                        a.isPresent
                     FROM teacherAttendance a
                     INNER JOIN teacherTb t ON a.teacherId = t.teacherId
                     WHERE a.teacherId = @teacherId
                     AND MONTH(a.attendDate) = @month
                     ORDER BY a.attendDate";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    cmd.Parameters.AddWithValue("@month", month);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtAttend.DataSource = dt;

                    // Optional: format columns
                    if (dtAttend.Columns.Contains("attendDate"))
                        dtAttend.Columns["attendDate"].HeaderText = "Date";
                    if (dtAttend.Columns.Contains("arrivalTime"))
                        dtAttend.Columns["arrivalTime"].HeaderText = "Arrival";
                    if (dtAttend.Columns.Contains("departureTime"))
                        dtAttend.Columns["departureTime"].HeaderText = "Departure";
                    if (dtAttend.Columns.Contains("isPresent"))
                        dtAttend.Columns["isPresent"].HeaderText = "Present";
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool loadTeacherAttendanceByDate(string teacherId, DateTime date, DataGridView dtAttend)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                        t.teacherName,
                        a.attendDate,
                        a.arrivalTime,
                        a.departureTime,
                        a.isPresent
                     FROM teacherAttendance a
                     INNER JOIN teacherTb t ON a.teacherId = t.teacherId
                     WHERE a.teacherId = @teacherId
                     AND CAST(a.attendDate AS DATE) = @date";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    cmd.Parameters.AddWithValue("@date", date.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtAttend.DataSource = dt;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static string GetTeacherIdByName(string teacherName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT teacherId FROM teacherTb WHERE teacherName=@teacherName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherName", teacherName);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        // ========================== 6. TEACHER HIRING & SUBJECTS ==========================
        public static bool laodSujectAndClassToTeacherHiring(DataGridView dt)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

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

                    if (!dt.Columns.Contains("Select"))
                    {
                        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                        chk.HeaderText = "Select";
                        chk.Name = "Select";
                        dt.Columns.Insert(0, chk);
                    }

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

        public static bool HireTeacherWithPassword(TeacherData data, string password, DataGridView dtSubjects)
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

                            // 3️⃣ Insert teacher payment info
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

                            // 4️⃣ Insert selected subjects
                            string insertSubject = @"
                        INSERT INTO teacherClassSubjectTb
                        (teacherId, classId, subjectId, domainId)
                        VALUES
                        (@teacherId, @classId, @subjectId, @domainId)";
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

                            // 5️⃣ Insert password
                            string insertPassword = @"
                        INSERT INTO teacherPassword
                        (teacherId, password)
                        VALUES
                        (@teacherId, @password)";
                            using (SqlCommand cmd = new SqlCommand(insertPassword, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@teacherId", data.TeacherId);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Error hiring teacher: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
                return false;
            }
        }

        // ========================== 7. EXPENSE MANAGEMENT ==========================
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
        //================excel file handling methods =========================
        // Alternative method using month numbers (more efficient)
        public static bool LoadExpenseByMonthRangeNumbers(DataGridView dgv, int year, int startMonth, int endMonth)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Ensure start month is not greater than end month
                    if (startMonth > endMonth)
                    {
                        int temp = startMonth;
                        startMonth = endMonth;
                        endMonth = temp;
                    }

                    string query = @"
                SELECT expenseId, expenseType, expenseAmount, expenseDate, expenseMonth, created_at
                FROM expenseTb
                WHERE YEAR(expenseDate) = @year
                AND MONTH(expenseDate) BETWEEN @startMonth AND @endMonth
                ORDER BY expenseDate";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"No expenses found for months {startMonth} to {endMonth} in {year}");
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }









    }
  }