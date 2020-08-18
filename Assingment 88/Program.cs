using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Incomr Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int Hour = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hours per week?");
            int week = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int Hourly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours per week?");
            int weeky = Convert.ToInt32(Console.ReadLine());

            
            int Annual = Hour * week;
            int total = Annual * 52;
            Console.WriteLine("Annual salary of Person 1 is: " + total);
            Console.ReadLine();

            int annual = Hourly * weeky;
            int Total = annual * 52;
            Console.WriteLine("Annual salary of Person 2 is: " + Total);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = Annual > annual;
            Console.WriteLine("Person 1 makes more money than Person 2:" + trueOrFalse);
            Console.ReadLine();
            



        }
    }
}
