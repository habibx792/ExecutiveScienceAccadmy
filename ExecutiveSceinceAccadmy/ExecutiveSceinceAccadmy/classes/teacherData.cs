using System;

namespace ExecutiveSceinceAccadmy.classes
{
    public class TeacherData
    {
        public string TeacherName { get; set; }
        public string TeacherId { get; set; }
        public string TeacherType { get; set; }
        public string FatherName { get; set; }
        public string FatherCNIC { get; set; }        // <-- added
        public string TeacherCnic { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string Address { get; set; }
        public string Qualification { get; set; }
        public string Salary { get; set; }
        public string Percentage { get; set; }

        public TeacherData(
            string teacherName,
            string teacherId,
            string teacherType,
            string fatherName,
            string fatherCNIC,                 // <-- added
            string teacherCnic,
            string addressCity,
            string addressCountry,
            string address,
            string qualification,
            string salary,
            string percentage)
        {
            TeacherName = teacherName;
            TeacherId = teacherId;
            TeacherType = teacherType;
            FatherName = fatherName;
            FatherCNIC = fatherCNIC;          // <-- assign
            TeacherCnic = teacherCnic;
            AddressCity = addressCity;
            AddressCountry = addressCountry;
            Address = address;
            Qualification = qualification;
            Salary = salary;
            Percentage = percentage;
        }

        public TeacherData() { }
    }
}
