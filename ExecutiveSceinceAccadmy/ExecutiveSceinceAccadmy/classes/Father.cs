using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Father:Person
    {
        private string job;
        public Father() {
            this.job = "Worker";
        }
        public Father(string name, int age, string personPhoneNumber, string cnic, string gender, string job)
            : base(name, age, personPhoneNumber, cnic, gender) { 
            this.job= job;

        }
        public Father(string job) {
            this.job = job;
        }
        public string Job { get => job; set => job = value; }
    }
}
