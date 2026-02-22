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
        protected string peronName;
        protected string PersonNumber;
        protected string cnic;
        protected string gender;
        public  Person()
        {

        }
        public Person(string name, int age,  string personPhoneNumber, string cnic, string gender)
        {
            this.name = name;
            this.age = age;
            this.PersonNumber = personPhoneNumber;
            this.cnic = cnic;
            this.gender = gender;   
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
       
        public string PersonPhoneNumber { get => PersonNumber; set => PersonNumber = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
