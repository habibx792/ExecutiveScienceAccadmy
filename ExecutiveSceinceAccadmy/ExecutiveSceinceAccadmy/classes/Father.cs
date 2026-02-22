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
        public Father() { }
        public Father(string job) {
            this.job = job;
        }
        public string Job { get => job; set => job = value; }
    }
}
