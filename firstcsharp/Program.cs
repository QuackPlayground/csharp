
using Microsoft.CodeAnalysis;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {

        // -- FUNCTIONS --


        // -- END OF FUNCTIONS

        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of the week: {0}",
                awesomeDate.DayOfWeek);

            // change value
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);

            Console.WriteLine("New Date: {0}",
                awesomeDate.Date);

            // Timespan to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time: {0}", lunchTime.ToString());
        }
    }
}