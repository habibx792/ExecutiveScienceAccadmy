using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Student:Person
    {
        private string classLevel;
        private string domainName;
        private string reqisterType;
      
        public Student() { }
        public Student(string name, int age, string personPhoneNumber, string cnic, string gender,string classLevel,string domain,string registerType)
            : base(name, age, personPhoneNumber, cnic, gender) {
            this.classLevel = classLevel;
            this.domainName = domain;
            this.reqisterType = registerType;
        }
        public string ClassLevel { get => classLevel; set => classLevel = value; }
        public string DomainName { get => domainName; set => domainName = value; }
        public string ReqisterType { get => reqisterType; set => reqisterType = value; }
        public accadmicHistory AcademicHistories { get; set; }
         public Father Father { get; set; }
         public Address Address { get; set; }
        
    }
}
