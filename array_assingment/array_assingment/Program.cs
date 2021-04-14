using System;
using System.Collections.Generic;

namespace array_assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a one-dimensional array of strings
            List<string> stringList = new List<string>() {"helloo", "no right now", "dose it work?" };

            //asking the host to type an index
            Console.WriteLine("choose a number between 0 and 2.");
            int number = Convert.ToInt32(Console.ReadLine());

            //using If Else to determain what index to show and stop program if a number is more then the index added
            if (number < 0 || number > 2)
            {
                Console.WriteLine("the following index dose not exists");
            }
            else
            {
                Console.WriteLine("you chose: " + stringList[number]);
            }
            Console.ReadLine();
            
            //again creating a one-dimensional array of integers
            List<int> intList = new List<int>() {10, 15, 25 };

            Console.WriteLine("choose a number between 0 and 2 to get an integer.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //using the If Else to give out the info of the chosen index
            if (number2 < 0 || number2 > 2)
            {
                Console.WriteLine("the following index dose not exists");
            }
            else
            {
                Console.WriteLine("you chose: " + intList[number2]);
            }
            Console.ReadLine();

            //creating a list of strings for user to select
            List<string> strList = new List<string>(); 
            strList.Add("hello");
            strList.Add("lets");
            strList.Add("hope this works out");
            

            Console.WriteLine("select an index 0f 0 to 2 to display the content.");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 < 0 || number3 > 2)
            {
                Console.WriteLine("the following index dose not exists");
            }
            else
            {
                Console.WriteLine("you chose: " + strList[number3]);
            }
            Console.ReadLine();



        }
    }
}
