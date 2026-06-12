using System;
using System.Collections.Generic;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Teacher : Person
    {
        protected string specialization;
        protected List<string> subjects;


        public Teacher()
        {
            subjects = new List<string>();
        }

        
        public Teacher(
            string name,
            int age,
            string dob,
            string fatherName,
            string personPhoneNumber,
            
            string cnic,
            string
            gender,
            string specialization,
            List<string> subjects
        ) : base(name, age, dob, personPhoneNumber, cnic,gender)
        {
            this.specialization = specialization;
            this.subjects = subjects;
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public List<string> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }

        // Helper Method (optional but useful)
        public void AddSubject(string subject)
        {
            if (!subjects.Contains(subject))
            {
                subjects.Add(subject);
            }
        }
    }
}
