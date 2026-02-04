using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Person
    {
        protected string name;
        protected int age;
        protected string fatherName;
        protected string personPhoneNumber;
        protected string fatherPhoneNumber;
        protected string cnic;
        public  Person()
        {

        }
        public Person(string name, int age, string fatherName, string personPhoneNumber, string fatherPhoneNumber, string cnic)
        {
            this.name = name;
            this.age = age;
            this.fatherName = fatherName;
            this.personPhoneNumber = personPhoneNumber;
            this.fatherPhoneNumber = fatherPhoneNumber;
            this.cnic = cnic;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string PersonPhoneNumber { get => personPhoneNumber; set => personPhoneNumber = value; }
        public string FatherPhoneNumber { get => fatherPhoneNumber; set => fatherPhoneNumber = value; }
        public string Cnic { get => cnic; set => cnic = value; }
    }
}
