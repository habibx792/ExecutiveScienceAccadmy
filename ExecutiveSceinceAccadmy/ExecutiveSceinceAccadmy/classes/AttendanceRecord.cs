using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class AttendanceRecord
    {
        private string attendanceID;
        private string registrationNo;
        private string date;
        private bool isPresent;
        private string attendanceType;
        private string day;
        public AttendanceRecord(string attendanceID, string registrationNo, string date, bool isPresent, string attendanceType, string day)
        {
            this.attendanceID = attendanceID;
            this.registrationNo = registrationNo;
            this.date = date;
            this.isPresent = isPresent;
            this.attendanceType = attendanceType;
            this.day = day;
        }
      public string AttendanceID { get => attendanceID; set => attendanceID = value; }
        public string RegistrationNo { get => registrationNo; set => registrationNo = value; }
        public string Date { get => date; set => date = value; }
        public bool IsPresent { get => isPresent; set => isPresent = value; }
        public string AttendanceType { get => attendanceType; set => attendanceType = value; }
        public string Day { get => day; set => day = value; }

    }

}
