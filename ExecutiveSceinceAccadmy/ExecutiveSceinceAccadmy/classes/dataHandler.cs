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
        public static string getCurrentDayOfMonth()
        {
            return DateTime.Now.ToString("dd");
        }
        public static string getCurrentMonthTwoDigits()
        {
            return DateTime.Now.ToString("MM");
        }
        public static string getStringDayOfWeek()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }
        public static string createRegistrationNumber(string domain, string gender, string classLevel)
        {
            return
                DB.createRegistrationNumber(domain, gender, classLevel);    

        }
        public static string getLastTwoDigitOfYear()
        {
            return DateTime.Now.Year.ToString().Substring(2, 2);
        }
        public static string getStringOfCurrentDate()
        {
            return DateTime.Now.ToString("yyyyMM");
        }
        public static string getStringOfDate()
        {
            return DateTime.Now.ToString("yyyyMMdd");
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
        public static string generateRandomeNumber(int length=5)
        {
            const string digits = "0123456789";
            Random rand = new Random();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(digits[rand.Next(digits.Length)]);
            }
            return result.ToString();
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
        public static List<int> loadPreviouseAndNextFiveYears()
        {
            int currentYear = getCurrentYear();
            List<int> years = new List<int>();
            for (int i = currentYear - 5; i <= currentYear + 5; i++)
            {
                years.Add(i);
            }
            return years;

        }
        public static List<string> GetPakistanCities()
        {
            return new List<string>
        {
            "Faisalabad",
            "Karachi",
            "Lahore",
            "Islamabad",
            "Rawalpindi",
            "Multan",
            "Peshawar",
            "Quetta",
            "Sialkot",
            "Gujranwala",
            "Hyderabad",
            "Bahawalpur",
            "Sukkur",
            "Mardan",
            "Abbottabad"
        };
        }
        public static List<string> GetQualifications()
        {
            return new List<string>
    {
        "BSSE",
        "BSCS",
        "BSIT",
        "BBA",
        "BCom",
        "BE",
        "MBBS",
        "BSc Physics",
        "BSc Chemistry",
        "BSc Biology",
        "BSc Mathematics",
        "BA English",
        "BA Urdu",
        "BA Islamiat",
        "BEd",
        "MSc Physics",
        "MSc Chemistry",
        "MSc Biology",
        "MSc Mathematics",
        "MSc Computer Science",
        "MSSE",
        "MBA",
        "MA English",
        "MA Urdu",
        "MA Islamiat",
        "MEd",
        "BFA",
        "BArch",
        "BS Economics",
        "BS Statistics"
    };
}



        // Method to return a list of countries
        public static List<string> GetCountries()
        {
            return new List<string>
        {
            "Pakistan",
            "America",
            "China",
            "Britain"
        };
        }
        public static string generatePassword(int len = 5)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";

            Random rand = new Random();
            StringBuilder pass = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                if (i == 0) 
                    pass.Append(upper[rand.Next(upper.Length)]);
                else if (i == 1) 
                    pass.Append(lower[rand.Next(lower.Length)]);
                else if (i == 2 || i == 3) 
                    pass.Append(numbers[rand.Next(numbers.Length)]);
                else 
                    pass.Append(upper[rand.Next(upper.Length)]);
            }
            return pass.ToString();
        }
    }
}
