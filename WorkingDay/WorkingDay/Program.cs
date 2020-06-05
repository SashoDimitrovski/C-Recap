using System;
using System.Collections.Generic;

namespace WorkingDay
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> daysOfTheWeek = new List<string>();
                daysOfTheWeek.Add("");
                Console.WriteLine("Is it a workign day?");
                Console.WriteLine("Press s to start");
                DateTime now = DateTime.Now;
                string start = Console.ReadLine();
                
                

            }
            string dateString = "12.5.1998";
            DateTime parsedDate = DateTime.Parse(dateString);
            Console.WriteLine(parsedDate);
            int day = parsedDate.Day;
            Console.WriteLine(day);
            DayOfWeek dow = parsedDate.DayOfWeek;
            Console.WriteLine(dow);
            string dowString = dow.ToString();

            if(dowString == "Tuesday")
            {
                Console.WriteLine("It'a working day!");
            }


        }
    }
}
