using System;
using System.Collections.Generic;

namespace array_assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            stringList.Add("your boyyyy");
            stringList.Add("heloooo");
            stringList.Add("noooo");

            Console.WriteLine("choose a number between 0 and 2.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[number]);
            Console.ReadLine();

            if (stringList.Count("2"))
                Console.WriteLine("You chose the following index " + stringList.IndexOf(number));
            else
                Console.WriteLine("theres nothing for that index");





            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(15);
            intList.Add(25);

            Console.WriteLine("choose a number between 0 and 2 to get an integer.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[number2]);
            Console.ReadLine();

            List<string[]> strList = new List<string[]>() {
            new string[] {"h", "i", "i"},
            new string[] {"lets", "goo"},
            new string[] {"hope", "this", "works", "out"},
            };

            Console.WriteLine("select an index 0f 0 to 2 to display the content.");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[number3]);
            Console.ReadLine();




        }
    }
}
