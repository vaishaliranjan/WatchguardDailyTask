using System;

namespace DateText
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------1. Date and Time ------------------------------------------------
            //DateTime and TimeSpan are immutable
            DateTime date = new DateTime(2015, 12, 11);
            //var date = new DateTime(2015, 12, 11);(year, month, day)
           // Console.WriteLine(date);


            //Time right now
            var now = DateTime.Now;
            //Console.WriteLine(now);
            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);
            //Console.WriteLine(now.Year);

            //var tomorrow = now.AddDays(1);
            //Console.WriteLine(tomorrow);
            //var yesterday = now.AddDays(-1);
            //Console.WriteLine(yesterday);
            //Console.WriteLine(now.AddMonths(1));



            //Only Date Today
            var today = DateTime.Today;
            //Console.WriteLine(today);

            //Function access via objects

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(today.ToString("yyyy-MM-dd HH:MM:ss"));

            //Console.WriteLine("Today date is "+ now.ToString("dd MMM yyyy")+ " and time is "+now.ToString("HH:MM"));



            //-------------------------------------------------------------------------2. TimeSPan --------------------------------------------
            TimeSpan timeSpan = new TimeSpan(11, 3, 56);//(hour, min, sec)           
            TimeSpan timeSpan1 = new TimeSpan(11, 0, 0);
            //other components ->0
            var timeSpan2 = TimeSpan.FromHours(13);
            var timespan3= TimeSpan.FromMinutes(12);
            var timeSpan4 = TimeSpan.FromSeconds(13);

            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timespan3);
            Console.WriteLine(timeSpan4);

            //Find Duration- subtract two DateTime
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddMinutes(1);
            var duration = date2 - date1; //when we subtract two datTime of same date then we get a timespan
            Console.WriteLine("Duration: "+duration);

            //Properties
            Console.WriteLine("Minute: "+timeSpan.Minutes);
            Console.WriteLine("Total Minuts: "+timeSpan2.TotalMinutes); //return hours->minutes

            //Add
            Console.WriteLine("Add: "+timeSpan.Add(new TimeSpan(12,0,0))); //add takes new timespan as an arg in TimeSpan
            //Subtract
            Console.WriteLine("Subtract: "+timeSpan.Subtract(TimeSpan.FromMinutes(1)));

            //To string
            Console.WriteLine("To string: "+timeSpan.ToString());

            //Parse- convert string to timespan
            Console.WriteLine("Parse: "+TimeSpan.Parse("12:22:00"));

            ///DateTime objects are immutable, which means once they're set, they cannot be changed. Here, AddYears() method returns a new DateTime object but we're not storing it in any variables.
            ///
            var dateTime = new DateTime(2015, 1, 1);
            //unchangeable
            dateTime.AddYears(1); //we need to store it in a variable or simply print it
            Console.WriteLine(dateTime.Year);


        }
    }
}