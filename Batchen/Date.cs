using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class Date
    {
        /*
        public static Date BuildDate(int day, int month, int year)
        {
            Date d = null;
            if (month >= 1 && month <= 12)
                d = new Date(day, month, year);
            return d;
        }
        */
        public int day, month, year;
        public Date(int day, int month, int year)
        { this.year = year; this.month = month; this.day = day; }

        public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) { }
        public Date(Date d) : this(d.GetDay(), d.GetMonth(), d.GetYear()) { }
        public void SetYear(int year) { this.year = year; }
        public int GetYear() { return this.year; }
        public void SetMonth(int month) { this.month = month; }
        public int GetMonth() { return this.month; }
        public void SetDay(int day) { this.day = day; }
        public int GetDay() { return this.day; }
        public int CompareTo(Date other)
        {
            if (this.year != other.GetYear()) return this.year - other.GetYear();
            else if (this.month != other.GetMonth()) return this.month - other.GetMonth();
            else return this.day - other.GetDay();
        }
        public override string ToString()
        {
            string str = "";
            str += this.day + "/";
            str += this.month + "/";
            str += this.year;
            return str;
        }
    }
}
