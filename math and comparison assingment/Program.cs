using System;

namespace math_and_comparison_assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1")
            Console.WriteLine("Hourly Rate?");
            int Hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int week = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int Hour2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int week2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1");
            int Annually = Hour * week * 52;
            Console.WriteLine(Annually);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2");
            int Annually2 = Hour2 * week2 * 52;
            Console.WriteLine(Annually2);
            Console.ReadLine();
        }
    }
}
