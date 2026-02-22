using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Student:Person
    {
        public Student() { }
        public Student(string name, int age, string personPhoneNumber, string cnic, string gender) : base(name, age, personPhoneNumber, cnic, gender) { }
        public accadmicHistory AcademicHistories { get; set; }
         public Father Father { get; set; }
         public Address Address { get; set; }
        
    }
}
