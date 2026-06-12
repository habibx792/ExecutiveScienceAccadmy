using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class accadmicHistory
    {
        private string schoolName;
        private string degree;
        private int passingYear;
        private int totalMarks;
        private int obtainedMarks;
        private string registrationNumber;
        private string board;

        public accadmicHistory() { }
        public accadmicHistory(string schoolName, string degree, int passingYear, int totalMarks, int obtainedMarks, string registrationNumber, string board)
        {
            this.schoolName = schoolName;
            this.degree = degree;
            this.passingYear = passingYear;
            this.totalMarks = totalMarks;
            this.obtainedMarks = obtainedMarks;
            this.registrationNumber = registrationNumber;
            this.board = board;
        }
        public string SchoolName { get => schoolName; set => schoolName = value; }
        public string Degree { get => degree; set => degree = value; }
        public int PassingYear { get => passingYear; set => passingYear = value; }
        public int TotalMarks { get => totalMarks;
            set => totalMarks = value;
        }
        public int ObtainedMarks { get => obtainedMarks; set => obtainedMarks = value; }
        public string RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public string Board { get => board; set => board = value; }


    }
}
