using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Web;
namespace ExecutiveSceinceAccadmy.classes
{
    public static class printEngine
    {
        public static void printDocument(string document)
        {
            // Implement printing logic here
            // This is a placeholder for the actual printing code
            Console.WriteLine("Printing document: " + document);
        }
        internal static string GenerateStudentDocument(Student std, string passWord, string registrationNumber)
        {
            Address addr = std.Address;
            Father father = std.Father;
            accadmicHistory academicHistory = std.AcademicHistories;

            string document = $@"
========== STUDENT REGISTRATION ==========
Registration No : {registrationNumber}
User Id         :{registrationNumber}
Passsword       :{passWord}

----- Student Information -----
Name        : {std.Name}
Age         : {std.Age}
Gender      : {std.Gender}
CNIC        : {std.Cnic}
Phone       : {std.PersonPhoneNumber}
DOB         : {std.DOB}
Domain      : {std.DomainName}
Class Level : {std.ClassLevel}
Type        : {std.ReqisterType}

----- Father Information -----
Name        : {father.Name}
CNIC        : {father.Cnic}
Phone       : {father.PersonPhoneNumber}
Job         : {father.Job}

----- Address -----
City        : {addr.City}
Country     : {addr.Country}
Address     : {addr.AddressLine}

----- Academic History -----
Degree      : {academicHistory.Degree}
School      : {academicHistory.SchoolName}
Board       : {academicHistory.Board}
PassingYear : {academicHistory.PassingYear}
Total Marks : {academicHistory.TotalMarks}
Obtained    : {academicHistory.ObtainedMarks}

==========================================
";

            return document;
        }
        internal static string SaveStudentDocument(string content, string studentName, string registraionNo)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Title = "Save Student Registration";
            saveDialog.Filter = "Text File (*.txt)|*.txt";
            saveDialog.FileName = $"{studentName}{registraionNo}{dataHandler.getRandomeTimeStr()}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, content);
                return saveDialog.FileName;
            }

            return null;
        }


        internal static void PrintFile(string filePath)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                string text = File.ReadAllText(filePath);

                Font font = new Font("Arial", 11);

                e.Graphics.DrawString(
                    text,
                    font,
                    Brushes.Black,
                    new RectangleF(50, 50,
                    e.MarginBounds.Width,
                    e.MarginBounds.Height)
                );
            };

            PrintDialog dialog = new PrintDialog();
            dialog.Document = pd;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        internal static bool printStudentRegistration(Student std, string passWord,
                                              string registrationNumber)
        {
            string document =
                GenerateStudentDocument(std, passWord, registrationNumber);

            string filePath =
                SaveStudentDocument(document, std.Name, registrationNumber);

            PrintFile(filePath);

            return true;
        }

        internal static bool printFeeReceipt(string feeId, string studentName,
     string registrationNumber,
     string monthFee,
     double feeAmount,
     double discountAmount,
     string percentage,
     string feeMonth,
     string currDate, string isPaid)
        {

            double finalFeeAmount = feeAmount - discountAmount;

            string document = $@"
========== EXECUTIVE SCIENCE ACADEMY ==========
               FEE RECEIPT

Student Name    : {studentName}
Registration No : {registrationNumber}
Fee ID         : {feeId}
Month           : {feeMonth}
Payment Date    : {currDate}
Paid Status     : {isPaid}
-----------------------------------------------
Original Fee    : {feeAmount}
Discount        : {discountAmount}
Discount %      : {percentage}
-----------------------------------------------
Paid Amount     : {finalFeeAmount}

-----------------------------------------------
Received By     : Admin
-----------------------------------------------

        Thank you for your payment!
===============================================
";

            string filePath = SaveStudentDocument(document, studentName, registrationNumber);

            if (filePath != null)
            {
                PrintFile(filePath);
                return true;
            }

            return false;
        }
    



      internal static string GenerateTeacherDocument(TeacherData teacher, string password, DataGridView dtTeacherSubject)
        {
            string document = $@"
========== TEACHER REGISTRATION ==========
Teacher ID      : {teacher.TeacherId}
User ID         : {teacher.TeacherId}
Password        : {password}

----- Personal Information -----
Name            : {teacher.TeacherName}
Type            : {teacher.TeacherType}
Father Name     : {teacher.FatherName}
Father CNIC     : {teacher.FatherCNIC}
Teacher CNIC    : {teacher.TeacherCnic}
City            : {teacher.AddressCity}
Country         : {teacher.AddressCountry}
Address         : {teacher.Address}
Qualification   : {teacher.Qualification}
Salary          : {teacher.Salary}
Percentage      : {teacher.Percentage}

----- Subjects Assigned -----
";

            // Loop through DataGridView and get selected subjects
            foreach (DataGridViewRow row in dtTeacherSubject.Rows)
            {
                // Assuming first column is checkbox, second column is subject name
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    string subjectName = row.Cells[1].Value.ToString();
                    document += $"• {subjectName}\n";
                }
            }

            document += @"
========================================
";

            return document;
        }

        // Save teacher document to file
        internal static string SaveTeacherDocument(string content, string teacherName, string teacherId)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Teacher Document";
            saveDialog.Filter = "Text File (*.txt)|*.txt";
            saveDialog.FileName = $"{teacherName}_{teacherId}_{dataHandler.getRandomeTimeStr()}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, content);
                return saveDialog.FileName;
            }

            return null;
        }

        // Print teacher document from file path
        internal static void PrintTeacherFile(string filePath)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                string text = File.ReadAllText(filePath);
                Font font = new Font("Arial", 11);
                e.Graphics.DrawString(
                    text,
                    font,
                    Brushes.Black,
                    new RectangleF(50, 50, e.MarginBounds.Width, e.MarginBounds.Height)
                );
            };

            PrintDialog dialog = new PrintDialog();
            dialog.Document = pd;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        // Full method: generate, save, and print teacher document
        internal static bool PrintTeacherDocument(TeacherData teacher, string password, DataGridView dtTeacherSubject)
        {
            string document = GenerateTeacherDocument(teacher, password, dtTeacherSubject);
            string filePath = SaveTeacherDocument(document, teacher.TeacherName, teacher.TeacherId);

            if (filePath != null)
            {
                PrintTeacherFile(filePath);
                return true;
            }

            return false;
        }
    }
}
