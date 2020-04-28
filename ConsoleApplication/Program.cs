/*CIT365 S2020
 * Aaron Foote
 * Week 1
 */


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
            Console.WriteLine($"My name is {name}!");
            Console.WriteLine($"I am from {location}!");


            //Current date, no time
            DateTime thisDay = DateTime.Today;

            //WriteLine output today's date
            Console.WriteLine();
             //Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine(thisDay.ToString("D"));


            //number of days till xmas
            DateTime today = DateTime.Today;
            DateTime xmasDay =new DateTime(DateTime.Today.Year, 12, 25);

            //compute days until christmas
            int daysLeft = xmasDay.DayOfYear - DateTime.Today.DayOfYear;

            //WriteLine output day's to xmas
            Console.WriteLine();
            Console.WriteLine($"There are {daysLeft} till Christmas!");

            //Add the program example from required reading section 2.1 C# Programming Yellow Book by Rob Miles.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //input for width
            Console.Write("Please enter the Width of Window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //input for height
            Console.Write("Please enter the Height of Window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);


            //computations for woodLength, glassArea
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //output of variables
            Console.WriteLine();
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of glass is {glassArea} square metres");





        }
    }// end class Program
} // end namespace ConsoleApplication
