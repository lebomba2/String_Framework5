using Microsoft.VisualBasic;
using System;

namespace String_Framework5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // the first 2 were done in a class experience

            Console.WriteLine($"{DateTime.Now,40:MMMM dd, yyyy}");
            Console.WriteLine($"{DateTime.Now:yyyy.dd.MM}");


            //3.Day 22 of January, 2019
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year; 
            Console.WriteLine($"Day {day} of {month}, {year}");

            //4.Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {year}, Month: {month}, Day: {day}");

            //5.Tuesday(10 spaces total, right aligned)
            string weekDay = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(String.Format("{0}", weekDay.PadLeft(10)));

            //6. 11:01 PM Tuesday(10 spaces total for each including the day - of - week, both right - aligned)
            string time = DateTime.Now.ToShortTimeString();
            Console.WriteLine(String.Format("{0}{1}", time.PadLeft(10), weekDay.PadLeft(10)));

            //7. h:11, m: 01, s: 27
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            Console.WriteLine($"h:{hour}, m:{minute}, s:{second}");

            //8. 2019.01.22.11.01.27
            Console.WriteLine($"{year}.{month}.{day}.{hour}.{minute}.{second}");
        }
    }
}
