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

            if (number < 0 || number > 2)
            {
                Console.WriteLine("the following index dose not exists");
            }
            else
            {
                Console.WriteLine("you chose: " + stringList[number]);
            }

            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(15);
            intList.Add(25);

            Console.WriteLine("choose a number between 0 and 2 to get an integer.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[number2]);
            Console.ReadLine();

            if (number2 < 0 || number2 > 2)
            {
                Console.WriteLine("the following index dose not exists");
            }
            else
            {
                Console.WriteLine("you chose: " + intList[number2]);
            }

            List<string[]> strList = new List<string[]>() {
            new string[] {"h", "i", "i"},
            new string[] {"lets", "goo"},
            new string[] {"hope", "this", "works", "out"},
            };

            Console.WriteLine("select an index 0f 0 to 2 to display the content.");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[number3]);
            Console.ReadLine();

            if (number3 < 0 || number3 > 2)
            {
                Console.WriteLine("the following index dose not exists");
            }
            else
            {
                Console.WriteLine("you chose: " + strList[number3]);
            }




        }
    }
}
