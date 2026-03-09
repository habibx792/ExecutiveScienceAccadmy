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
        internal static string GenerateStudentDocument(Student std, string registrationNumber)
        {
            Address addr = std.Address;
            Father father = std.Father;
            accadmicHistory academicHistory = std.AcademicHistories;

            string document = $@"
========== STUDENT REGISTRATION ==========
Registration No : {registrationNumber}

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
        internal static string SaveStudentDocument(string content,string registraionNo)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Title = "Save Student Registration";
            saveDialog.Filter = "Text File (*.txt)|*.txt";
            saveDialog.FileName = $"{registraionNo}+{DateTime.Now}.txt";

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
        internal static bool printStudentRegistration(Student std,
                                              string registrationNumber)
        {
            string document =
                GenerateStudentDocument(std, registrationNumber);

            string filePath =
                SaveStudentDocument(document,registrationNumber);

            PrintFile(filePath);

            return true;
        }
        internal static bool printFeeReceipt(
     string registrationNumber,
     string monthFee,
     double feeAmount,
     double discountAmount,
     string percentage,
     string feeMonth,
     string currDate)
        {

            double finalFeeAmount = feeAmount - discountAmount;

            string document = $@"
========== EXECUTIVE SCIENCE ACADEMY ==========
               FEE RECEIPT

Registration No : {registrationNumber}
Month           : {feeMonth}
Payment Date    : {currDate}

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

            string filePath = SaveStudentDocument(document, registrationNumber);

            if (filePath != null)
            {
                PrintFile(filePath);
                return true;
            }

            return false;
        }
    }
}
