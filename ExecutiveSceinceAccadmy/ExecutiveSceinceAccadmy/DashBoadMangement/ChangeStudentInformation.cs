using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExecutiveSceinceAccadmy.classes;
using Microsoft.Data.SqlClient;

namespace ExecutiveSceinceAccadmy.DashBoadMangement
{
    public partial class ChangeStudentInformation : Form
    {
        private string? selectedRegistrationNo;
        private bool isBindingGrid;

        public ChangeStudentInformation()
        {
            InitializeComponent();
            AutoScroll = true;
            ConfigureForm();
            WireEvents();
            EnsureSsTableExists();
            LoadComboBoxes();
            SetDetailControlsEnabled(false);
        }

        private void ConfigureForm()
        {
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtpUpdateDate.Value = DateTime.Today;
            btnLoad.Enabled = false;
        }

        private void EnsureSsTableExists()
        {
            try
            {
                using SqlConnection con = DB.getConnection();
                EnsureSsTableExists(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ssTable setup error: " + ex.Message);
            }
        }

        private void EnsureSsTableExists(SqlConnection con, SqlTransaction? transaction = null)
        {
            string query = @"
                IF OBJECT_ID('dbo.ssTable', 'U') IS NULL
                BEGIN
                    CREATE TABLE dbo.ssTable
                    (
                        ssId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                        stdRegisNo VARCHAR(50) NOT NULL UNIQUE,
                        student_contact VARCHAR(20) NULL,
                        whatsapp_number VARCHAR(20) NULL,
                        updated_by VARCHAR(100) NULL,
                        change_reason VARCHAR(500) NULL,
                        update_date DATETIME NULL,
                        created_at DATETIME NULL CONSTRAINT DF_ssTable_created_at DEFAULT GETDATE(),
                        updated_at DATETIME NULL,
                        CONSTRAINT FK_ssTable_StudentTb
                            FOREIGN KEY (stdRegisNo) REFERENCES dbo.StudentTb(stdRegisNo)
                    );
                END;

                IF COL_LENGTH('dbo.ssTable', 'student_contact') IS NULL
                    ALTER TABLE dbo.ssTable ADD student_contact VARCHAR(20) NULL;

                IF COL_LENGTH('dbo.ssTable', 'whatsapp_number') IS NULL
                    ALTER TABLE dbo.ssTable ADD whatsapp_number VARCHAR(20) NULL;

                IF COL_LENGTH('dbo.ssTable', 'updated_by') IS NULL
                    ALTER TABLE dbo.ssTable ADD updated_by VARCHAR(100) NULL;

                IF COL_LENGTH('dbo.ssTable', 'change_reason') IS NULL
                    ALTER TABLE dbo.ssTable ADD change_reason VARCHAR(500) NULL;

                IF COL_LENGTH('dbo.ssTable', 'update_date') IS NULL
                    ALTER TABLE dbo.ssTable ADD update_date DATETIME NULL;

                IF COL_LENGTH('dbo.ssTable', 'created_at') IS NULL
                    ALTER TABLE dbo.ssTable ADD created_at DATETIME NULL CONSTRAINT DF_ssTable_created_at DEFAULT GETDATE();

                IF COL_LENGTH('dbo.ssTable', 'updated_at') IS NULL
                    ALTER TABLE dbo.ssTable ADD updated_at DATETIME NULL;";

            using SqlCommand cmd = new SqlCommand(query, con, transaction);
            cmd.ExecuteNonQuery();
        }

        private void WireEvents()
        {
            btnSearch.Click += btnSearch_Click;
            btnLoad.Click += btnLoad_Click;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            dgvStudents.CellDoubleClick += dgvStudents_CellDoubleClick;
            btnUpdate.Click += btnUpdate_Click;
            btnClear.Click += btnClear_Click;
            btnCancel.Click += btnCancel_Click;
            btnClose.Click += btnClose_Click;
        }

        private void LoadComboBoxes()
        {
            if (cmbSearchBy.Items.Count > 0)
                cmbSearchBy.SelectedIndex = 0;

            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Custom" });
            cmbGender.SelectedIndex = 0;

            cmbFatherJob.Items.Clear();
            cmbFatherJob.Items.AddRange(new object[]
            {
                "Business", "Government Employee", "Private Employee", "Teacher",
                "Farmer", "Labor", "Doctor", "Engineer", "Other"
            });
            cmbFatherJob.SelectedIndex = 0;

            cmbClass.Items.Clear();
            cmbClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9th", "10th", "11th", "12th" });

            cmbPrvDeg.Items.Clear();
            cmbPrvDeg.Items.AddRange(new object[] { "Primary", "Middle", "Matric", "O Level", "Intermediate", "Other" });

            cmbBoard.Items.Clear();
            cmbBoard.Items.AddRange(new object[] { "BISE Lahore", "BISE Gujranwala", "BISE Faisalabad", "BISE Multan", "Federal Board", "Other" });

            cmbPassingYear.Items.Clear();
            foreach (int year in dataHandler.laodPrevisous_10Years())
                cmbPassingYear.Items.Add(year.ToString());

            cmbDomain.Items.Clear();
            try
            {
                foreach (string domain in DB.loadALlDomain())
                    cmbDomain.Items.Add(domain);
            }
            catch
            {
                // Domains can still be typed manually if the database is unavailable at startup.
            }
        }

        private void SetDetailControlsEnabled(bool enabled)
        {
            Control[] controls =
            {
                txtStdName, txtStdFatherName, txtStdCNIC, txtFatherCNIC, dtpDOB, cmbGender, cmbFatherJob,
                txtStdContact, txtFatherContact, txtWatsApp, txtCity, txtStdAddress,
                cmbClass, cmbDomain, cmbPrvDeg, cmbBoard, cmbPassingYear,
                rdReg, rdRTS, rdPrim, rdSuple,
                txtPrevReg, txtSchool, txtObtainedMarks, txtTotalMark,
                dtpUpdateDate, txtUpdatedBy, txtChangeReason,
                btnUpdate, btnClear, btnCancel
            };

            foreach (Control control in controls)
                control.Enabled = enabled;
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            SearchStudents();
        }

        private void btnLoad_Click(object? sender, EventArgs e)
        {
            LoadSelectedStudentFromGrid();
        }

        private void dgvStudents_SelectionChanged(object? sender, EventArgs e)
        {
            if (isBindingGrid)
                return;

            LoadSelectedStudentFromGrid();
        }

        private void dgvStudents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                LoadSelectedStudentFromGrid();
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            UpdateStudent();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearDetailFields();
            SetDetailControlsEnabled(false);
            selectedRegistrationNo = null;
            btnLoad.Enabled = dgvStudents.Rows.Count > 0;
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectedRegistrationNo))
                LoadStudentDetails(selectedRegistrationNo);
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void SearchStudents()
        {
            string searchText = txtSearchStudent.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter search text.");
                return;
            }

            try
            {
                using SqlConnection con = DB.getConnection();
                EnsureSsTableExists(con);
                string whereClause = GetSearchWhereClause(cmbSearchBy.Text);

                string query = $@"
                    SELECT TOP 50
                        s.stdRegisNo AS [Registration Number],
                        s.student_name AS [Student Name],
                        s.cnic AS [Student CNIC],
                        s.father_name AS [Father Name],
                        s.father_mobile_no AS [Father Mobile No],
                        ss.student_contact AS [Student Contact],
                        ss.whatsapp_number AS [WhatsApp Number],
                        s.student_type AS [Student Type]
                    FROM StudentTb s
                    LEFT JOIN ssTable ss ON ss.stdRegisNo = s.stdRegisNo
                    WHERE {whereClause}
                    ORDER BY s.student_name";

                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                DataTable table = new DataTable();
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

                isBindingGrid = true;
                dgvStudents.DataSource = table;
                isBindingGrid = false;

                btnLoad.Enabled = table.Rows.Count > 0;

                if (table.Rows.Count == 0)
                {
                    ClearDetailFields();
                    SetDetailControlsEnabled(false);
                    selectedRegistrationNo = null;
                    MessageBox.Show("No student found.");
                    return;
                }

                dgvStudents.ClearSelection();
                dgvStudents.Rows[0].Selected = true;
                LoadSelectedStudentFromGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private string GetSearchWhereClause(string searchBy)
        {
            return searchBy switch
            {
                "Registration Number" => "s.stdRegisNo LIKE @search",
                "Student CNIC" => "s.cnic LIKE @search",
                "Student Name" => "s.student_name LIKE @search",
                "Student Contact" => "(ss.student_contact LIKE @search OR ss.whatsapp_number LIKE @search OR s.father_mobile_no LIKE @search)",
                _ => "s.stdRegisNo LIKE @search"
            };
        }

        private void LoadSelectedStudentFromGrid()
        {
            if (dgvStudents.CurrentRow == null || dgvStudents.CurrentRow.Cells["Registration Number"].Value == null)
                return;

            string registrationNo = dgvStudents.CurrentRow.Cells["Registration Number"].Value.ToString() ?? "";
            if (!string.IsNullOrWhiteSpace(registrationNo))
                LoadStudentDetails(registrationNo);
        }

        private void LoadStudentDetails(string registrationNo)
        {
            try
            {
                using SqlConnection con = DB.getConnection();
                EnsureSsTableExists(con);

                string query = @"
                    SELECT
                        s.stdRegisNo,
                        s.student_name,
                        s.domainId,
                        s.classId,
                        c.className,
                        s.gender,
                        s.date_of_birth,
                        s.updated_at,
                        s.cnic,
                        s.father_name,
                        s.father_cnic,
                        s.father_occupation,
                        s.father_mobile_no,
                        s.student_type,
                        ss.student_contact,
                        ss.whatsapp_number,
                        ss.updated_by,
                        ss.change_reason,
                        ss.update_date AS ss_update_date,
                        a.previous_qualification,
                        a.passingYear,
                        a.registrationNo AS previous_registration_no,
                        a.previous_school_name,
                        a.TotalMarks,
                        a.gainMarks,
                        a.board,
                        ad.address,
                        ad.city
                    FROM StudentTb s
                    LEFT JOIN classTb c ON s.classId = c.classId AND s.domainId = c.domainId
                    LEFT JOIN academicTb a ON a.stdRegisNo = s.stdRegisNo
                    LEFT JOIN stdAdress ad ON ad.stdRegisNo = s.stdRegisNo
                    LEFT JOIN ssTable ss ON ss.stdRegisNo = s.stdRegisNo
                    WHERE s.stdRegisNo = @registrationNo";

                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@registrationNo", registrationNo);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("Selected student record was not found.");
                    return;
                }

                selectedRegistrationNo = registrationNo;
                txtStdName.Text = ReadString(reader, "student_name");
                txtStdFatherName.Text = ReadString(reader, "father_name");
                txtStdCNIC.Text = ReadString(reader, "cnic");
                txtFatherCNIC.Text = ReadString(reader, "father_cnic");
                SetComboText(cmbGender, ReadString(reader, "gender"));
                SetComboText(cmbFatherJob, ReadString(reader, "father_occupation"));
                txtFatherContact.Text = ReadString(reader, "father_mobile_no");
                txtStdContact.Text = ReadString(reader, "student_contact");
                txtWatsApp.Text = ReadString(reader, "whatsapp_number");
                txtCity.Text = ReadString(reader, "city");
                txtStdAddress.Text = ReadString(reader, "address");
                SetComboText(cmbDomain, ReadString(reader, "domainId"));
                SetComboText(cmbClass, ReadString(reader, "className"));
                SetComboText(cmbPrvDeg, ReadString(reader, "previous_qualification"));
                SetComboText(cmbPassingYear, ReadString(reader, "passingYear"));
                SetComboText(cmbBoard, ReadString(reader, "board"));
                txtPrevReg.Text = ReadString(reader, "previous_registration_no");
                txtSchool.Text = ReadString(reader, "previous_school_name");
                txtTotalMark.Text = ReadString(reader, "TotalMarks");
                txtObtainedMarks.Text = ReadString(reader, "gainMarks");
                txtUpdatedBy.Text = ReadString(reader, "updated_by");
                txtChangeReason.Text = ReadString(reader, "change_reason");
                dtpUpdateDate.Value = DateTime.Today;
                if (DateTime.TryParse(ReadString(reader, "ss_update_date"), out DateTime ssUpdateDate))
                    dtpUpdateDate.Value = ssUpdateDate;
                else if (DateTime.TryParse(ReadString(reader, "updated_at"), out DateTime updatedAt))
                    dtpUpdateDate.Value = updatedAt;

                if (DateTime.TryParse(ReadString(reader, "date_of_birth"), out DateTime dob))
                    dtpDOB.Value = dob;

                SetStudentType(ReadString(reader, "student_type"));
                SetDetailControlsEnabled(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load student error: " + ex.Message);
            }
        }

        private void UpdateStudent()
        {
            if (string.IsNullOrWhiteSpace(selectedRegistrationNo))
            {
                MessageBox.Show("Please search and select a student first.");
                return;
            }

            if (!ValidateInputs())
                return;

            using SqlConnection con = DB.getConnection();
            using SqlTransaction transaction = con.BeginTransaction();

            try
            {
                EnsureSsTableExists(con, transaction);
                int classId = GetClassId(con, transaction, cmbDomain.Text.Trim(), cmbClass.Text.Trim());

                List<string> setParts = new List<string>
                {
                    "student_name = @student_name",
                    "domainId = @domainId",
                    "classId = @classId",
                    "gender = @gender",
                    "date_of_birth = @date_of_birth",
                    "cnic = @cnic",
                    "father_name = @father_name",
                    "father_cnic = @father_cnic",
                    "father_occupation = @father_occupation",
                    "father_mobile_no = @father_mobile_no",
                    "student_type = @student_type",
                    "updated_at = @update_date"
                };

                string studentQuery = $@"
                    UPDATE StudentTb
                    SET {string.Join(", ", setParts)}
                    WHERE stdRegisNo = @stdRegisNo";

                using (SqlCommand cmd = new SqlCommand(studentQuery, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@stdRegisNo", selectedRegistrationNo);
                    cmd.Parameters.AddWithValue("@student_name", txtStdName.Text.Trim());
                    cmd.Parameters.AddWithValue("@domainId", cmbDomain.Text.Trim());
                    cmd.Parameters.AddWithValue("@classId", classId);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text.Trim());
                    cmd.Parameters.AddWithValue("@date_of_birth", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@cnic", txtStdCNIC.Text.Trim());
                    cmd.Parameters.AddWithValue("@father_name", txtStdFatherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@father_cnic", txtFatherCNIC.Text.Trim());
                    cmd.Parameters.AddWithValue("@father_occupation", ToDbValue(cmbFatherJob.Text.Trim()));
                    cmd.Parameters.AddWithValue("@father_mobile_no", txtFatherContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@student_type", GetSelectedStudentType());
                    cmd.Parameters.AddWithValue("@update_date", dtpUpdateDate.Value.Date);
                    cmd.ExecuteNonQuery();
                }

                UpsertAcademic(con, transaction);
                UpsertAddress(con, transaction);
                UpsertStudentSupport(con, transaction);

                transaction.Commit();
                MessageBox.Show("Student information updated successfully.");
                SearchStudents();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void UpsertAcademic(SqlConnection con, SqlTransaction transaction)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM academicTb WHERE stdRegisNo = @stdRegisNo)
                BEGIN
                    UPDATE academicTb
                    SET previous_qualification = @previous_qualification,
                        passingYear = @passingYear,
                        registrationNo = @registrationNo,
                        previous_school_name = @previous_school_name,
                        TotalMarks = @TotalMarks,
                        gainMarks = @gainMarks,
                        board = @board
                    WHERE stdRegisNo = @stdRegisNo
                END
                ELSE
                BEGIN
                    INSERT INTO academicTb
                    (stdRegisNo, previous_qualification, passingYear, registrationNo,
                     previous_school_name, TotalMarks, gainMarks, board)
                    VALUES
                    (@stdRegisNo, @previous_qualification, @passingYear, @registrationNo,
                     @previous_school_name, @TotalMarks, @gainMarks, @board)
                END";

            using SqlCommand cmd = new SqlCommand(query, con, transaction);
            cmd.Parameters.AddWithValue("@stdRegisNo", selectedRegistrationNo);
            cmd.Parameters.AddWithValue("@previous_qualification", ToDbValue(cmbPrvDeg.Text.Trim()));
            cmd.Parameters.AddWithValue("@passingYear", ToDbValue(cmbPassingYear.Text.Trim()));
            cmd.Parameters.AddWithValue("@registrationNo", ToDbValue(txtPrevReg.Text.Trim()));
            cmd.Parameters.AddWithValue("@previous_school_name", ToDbValue(txtSchool.Text.Trim()));
            cmd.Parameters.AddWithValue("@TotalMarks", ToIntDbValue(txtTotalMark.Text.Trim()));
            cmd.Parameters.AddWithValue("@gainMarks", ToIntDbValue(txtObtainedMarks.Text.Trim()));
            cmd.Parameters.AddWithValue("@board", ToDbValue(cmbBoard.Text.Trim()));
            cmd.ExecuteNonQuery();
        }

        private void UpsertAddress(SqlConnection con, SqlTransaction transaction)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM stdAdress WHERE stdRegisNo = @stdRegisNo)
                BEGIN
                    UPDATE stdAdress
                    SET address = @address,
                        city = @city,
                        country = @country
                    WHERE stdRegisNo = @stdRegisNo
                END
                ELSE
                BEGIN
                    INSERT INTO stdAdress (stdRegisNo, address, city, country)
                    VALUES (@stdRegisNo, @address, @city, @country)
                END";

            using SqlCommand cmd = new SqlCommand(query, con, transaction);
            cmd.Parameters.AddWithValue("@stdRegisNo", selectedRegistrationNo);
            cmd.Parameters.AddWithValue("@address", ToDbValue(txtStdAddress.Text.Trim()));
            cmd.Parameters.AddWithValue("@city", ToDbValue(txtCity.Text.Trim()));
            cmd.Parameters.AddWithValue("@country", "Pakistan");
            cmd.ExecuteNonQuery();
        }

        private void UpsertStudentSupport(SqlConnection con, SqlTransaction transaction)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM ssTable WHERE stdRegisNo = @stdRegisNo)
                BEGIN
                    UPDATE ssTable
                    SET student_contact = @student_contact,
                        whatsapp_number = @whatsapp_number,
                        updated_by = @updated_by,
                        change_reason = @change_reason,
                        update_date = @update_date,
                        updated_at = GETDATE()
                    WHERE stdRegisNo = @stdRegisNo
                END
                ELSE
                BEGIN
                    INSERT INTO ssTable
                    (stdRegisNo, student_contact, whatsapp_number, updated_by, change_reason, update_date, updated_at)
                    VALUES
                    (@stdRegisNo, @student_contact, @whatsapp_number, @updated_by, @change_reason, @update_date, GETDATE())
                END";

            using SqlCommand cmd = new SqlCommand(query, con, transaction);
            cmd.Parameters.AddWithValue("@stdRegisNo", selectedRegistrationNo);
            cmd.Parameters.AddWithValue("@student_contact", ToDbValue(txtStdContact.Text.Trim()));
            cmd.Parameters.AddWithValue("@whatsapp_number", ToDbValue(txtWatsApp.Text.Trim()));
            cmd.Parameters.AddWithValue("@updated_by", ToDbValue(txtUpdatedBy.Text.Trim()));
            cmd.Parameters.AddWithValue("@change_reason", ToDbValue(txtChangeReason.Text.Trim()));
            cmd.Parameters.AddWithValue("@update_date", dtpUpdateDate.Value);
            cmd.ExecuteNonQuery();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtStdName.Text))
            {
                MessageBox.Show("Student name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStdFatherName.Text))
            {
                MessageBox.Show("Father name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbDomain.Text) || cmbDomain.Text == "Domain")
            {
                MessageBox.Show("Domain is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbClass.Text) || cmbClass.Text == "Class")
            {
                MessageBox.Show("Class is required.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTotalMark.Text) && !int.TryParse(txtTotalMark.Text, out _))
            {
                MessageBox.Show("Total marks must be a number.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtObtainedMarks.Text) && !int.TryParse(txtObtainedMarks.Text, out _))
            {
                MessageBox.Show("Obtained marks must be a number.");
                return false;
            }

            return true;
        }

        private int GetClassId(SqlConnection con, SqlTransaction transaction, string domainId, string classText)
        {
            string className = NormalizeClassName(classText);
            string query = @"SELECT classId FROM classTb WHERE domainId = @domainId AND className = @className";

            using SqlCommand cmd = new SqlCommand(query, con, transaction);
            cmd.Parameters.AddWithValue("@domainId", domainId);
            cmd.Parameters.AddWithValue("@className", className);

            object? result = cmd.ExecuteScalar();
            if (result == null || result == DBNull.Value)
                throw new Exception("Invalid class/domain combination.");

            return Convert.ToInt32(result);
        }

        private string NormalizeClassName(string classText)
        {
            string value = classText.Trim();
            if (int.TryParse(value.Replace("th", ""), out int classNumber))
            {
                if (classNumber <= 8)
                    return classNumber.ToString();

                return classNumber + "th";
            }

            return value;
        }

        private HashSet<string> GetTableColumns(SqlConnection con, string tableName, SqlTransaction? transaction = null)
        {
            HashSet<string> columns = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            string query = @"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName";

            using SqlCommand cmd = new SqlCommand(query, con, transaction);
            cmd.Parameters.AddWithValue("@tableName", tableName);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                columns.Add(reader.GetString(0));

            return columns;
        }

        private string BuildOptionalSelect(HashSet<string> tableColumns, IEnumerable<string> candidateColumns, string alias)
        {
            string? column = FindExistingColumn(tableColumns, candidateColumns);
            if (column == null)
                return $"CAST(NULL AS NVARCHAR(100)) AS [{alias}]";

            return $"s.[{column}] AS [{alias}]";
        }

        private string? FindExistingColumn(HashSet<string> tableColumns, IEnumerable<string> candidateColumns)
        {
            return candidateColumns.FirstOrDefault(tableColumns.Contains);
        }

        private void AddOptionalSet(List<string> setParts, string? columnName, string parameterName)
        {
            if (!string.IsNullOrWhiteSpace(columnName))
                setParts.Add($"[{columnName}] = {parameterName}");
        }

        private List<string> GetSkippedFields(
            string? studentContactColumn,
            string? whatsAppColumn,
            string? updatedByColumn,
            string? changeReasonColumn)
        {
            List<string> skippedFields = new List<string>();

            if (studentContactColumn == null && !string.IsNullOrWhiteSpace(txtStdContact.Text))
                skippedFields.Add("Student Contact");

            if (whatsAppColumn == null && !string.IsNullOrWhiteSpace(txtWatsApp.Text))
                skippedFields.Add("WhatsApp Number");

            if (updatedByColumn == null && !string.IsNullOrWhiteSpace(txtUpdatedBy.Text))
                skippedFields.Add("Updated By");

            if (changeReasonColumn == null && !string.IsNullOrWhiteSpace(txtChangeReason.Text))
                skippedFields.Add("Reason/Remarks");

            return skippedFields;
        }

        private string ReadString(SqlDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ordinal))
                return "";

            return reader.GetValue(ordinal).ToString() ?? "";
        }

        private void SetComboText(ComboBox comboBox, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return;

            int index = comboBox.FindStringExact(value);
            if (index >= 0)
                comboBox.SelectedIndex = index;
            else
                comboBox.Text = value;
        }

        private void SetStudentType(string studentType)
        {
            rdReg.Checked = studentType.Equals("Regular", StringComparison.OrdinalIgnoreCase);
            rdRTS.Checked = studentType.Equals("RTS", StringComparison.OrdinalIgnoreCase);
            rdPrim.Checked = studentType.Equals("Primary", StringComparison.OrdinalIgnoreCase);
            rdSuple.Checked = studentType.Equals("Supplementary", StringComparison.OrdinalIgnoreCase)
                              || studentType.Equals("Suplemenrtary", StringComparison.OrdinalIgnoreCase);

            if (!rdReg.Checked && !rdRTS.Checked && !rdPrim.Checked && !rdSuple.Checked)
                rdReg.Checked = true;
        }

        private string GetSelectedStudentType()
        {
            if (rdRTS.Checked)
                return "RTS";

            if (rdPrim.Checked)
                return "Primary";

            if (rdSuple.Checked)
                return "Suplemenrtary";

            return "Regular";
        }

        private object ToDbValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return DBNull.Value;

            return value;
        }

        private object ToIntDbValue(string value)
        {
            if (int.TryParse(value, out int number))
                return number;

            return DBNull.Value;
        }

        private void ClearDetailFields()
        {
            txtStdName.Clear();
            txtStdFatherName.Clear();
            txtStdCNIC.Clear();
            txtFatherCNIC.Clear();
            txtStdContact.Clear();
            txtFatherContact.Clear();
            txtWatsApp.Clear();
            txtCity.Clear();
            txtStdAddress.Clear();
            txtPrevReg.Clear();
            txtSchool.Clear();
            txtObtainedMarks.Clear();
            txtTotalMark.Clear();
            txtUpdatedBy.Clear();
            txtChangeReason.Clear();
            dtpDOB.Value = DateTime.Today;
            dtpUpdateDate.Value = DateTime.Today;
            rdReg.Checked = true;
        }
    }
}
