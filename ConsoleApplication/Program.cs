using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Output two WriteLine statements that dispaly two variables
            //variables
            string name = "Aaron Foote";
            string location = "Arizona";

            //WriteLine outputs
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I am from " + location + "!");


            //Current date, no time
            DateTime thisDay = DateTime.Today;

            //WriteLine output today's date
            Console.WriteLine();
            Console.WriteLine(thisDay.ToString("D"));


            //number of days till xmas
            DateTime today = DateTime.Today;
            DateTime xmasDay =new DateTime(DateTime.Today.Year, 12, 25);

            //compute days until christmas
            int daysLeft = xmasDay.DayOfYear - DateTime.Today.DayOfYear;

            //WriteLine output day's to xmas
            Console.WriteLine();
            Console.WriteLine("There are " + daysLeft + " till Christmas!");
            




        }
    }
}
