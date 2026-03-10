using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal static class dataHandler
    {
        public static string stringTrim(string data)
        {
            return data.Trim();
        }
        public static bool isValidAge(int age)
        {
            return age >= 3 && age <= 70;
        }
        public static int getCurrentYear()
        {
            return DateTime.Now.Year;
        }
        public static int getCurrentMonth()
        {
            return DateTime.Now.Month;
        }
        public static int getCurrentDay()
        {
            return DateTime.Now.Day;
        }
        public static string getCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
        public static string getCurrentMonthStr()
        {
            return DateTime.Now.ToString("MMMM");
        }
        public static string getCurrentDayStr()
        {
            return DateTime.Now.ToString("dddd");
        }
        public static string getCurrentDateStr()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
        public static string currentYearLastTwoDigits()
        {
            return DateTime.Now.ToString("yy");
        }
        public static string createRegistrationNumber(string domain, string gender, string classLevel)
        {
            int currStd=DB.getCurrentStdNumber() + 1;
            string year = currentYearLastTwoDigits();
            DB.updateCurrentStdNumber(currStd);
            return year + "-" + classLevel + "-" + domain + "-"+gender +"-"+ currStd.ToString();

        }
        public static int calculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
        public static List<int> laodPrevisous_10Years()
        {
            int currYear = getCurrentYear();
            List<int> years = new List<int>();
            for(int i=currYear-20;i<=currYear;i++)
            {
                years.Add(i);
            }
            return years;
        }
        public static string GenerateShortId(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static void  LoadMonths(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                comboBox.Items.Add(new DateTime(1, month, 1).ToString("MMMM"));
            }
        }
        public static string getRandomeTimeStr()
        { 
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            const string digits = "0123456789";
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            StringBuilder result = new StringBuilder();

            foreach (char c in timestamp)
            {

                if (rand.Next(2) == 0)
                {
                    result.Append(c);
                }
                else
                {
                    int digit = int.Parse(c.ToString());
               
                    result.Append(letters[rand.Next(letters.Length)]);
                }
            }
            return result.ToString();
        }
    }
}
