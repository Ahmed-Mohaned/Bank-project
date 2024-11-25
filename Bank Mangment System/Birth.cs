using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangment_System
{
    public class Birth
    {
        private int day;
        private int month;
       private int year;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Age()
        {
            DateTime current = DateTime.Now;
            int age = current.Year - year;
            return age;
        }
    }
}
