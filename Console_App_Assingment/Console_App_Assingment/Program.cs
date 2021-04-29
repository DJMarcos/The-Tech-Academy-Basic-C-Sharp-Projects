using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array of strings 
            string[] stringArray = { "yooo", "hiiii", "wait", "goodbye", "dont" };

            //asking the user to input some text on the console
            Console.WriteLine("Please type some text to see if this works");
            string Write = Convert.ToString(Console.ReadLine());

            //
            for (int s = 0; s < stringArray.Length; s++)
            {
                stringArray[s] += Write;
                //stringArray[s] = stringArray[s] + Write;
            }


            foreach (string word in stringArray)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            ////this will be an infinite loop
            //int k = 0;
            //while (k < 0)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //    break;
            //}

            //fixed the infinite loop so that it will execute properly
            int i = 0;
            while (i >= -2)
            {
                Console.WriteLine(i);
                i--;
            }


            //a loop where the comparison that used to determaine whether to continue iterating the loop is a "<" operator
            for (int m = 0; m < 8; m++)
            {
                {
                    Console.WriteLine(m);
                }
            }
            Console.ReadLine();

            //a loop where the comparison that used to determain wether to continue iterating the loop is a "<="
            for (int g = 0; g <= 8; g++)
            {
                Console.WriteLine(g);
            }
            Console.ReadLine();

            //a list of strings where each item in the list is unique
            List<string> nameString = new List<string>() { "apple", "bananna", "cocanut", "door" };

            Console.WriteLine("choose a fruit that youll eat like apple, bananna, cocanut or a door");
            string chose = Console.ReadLine();
            bool found = false;

            for (int c = 0; c < nameString.Count; c++)
            {
                //if responds is equal to any index on the namestring do a loop
                if (chose == nameString[c])
                {
                    //display the C or index 
                    Console.WriteLine(c);
                    //this means do a loop until it is true then break to stop the loop
                    found = true;
                    //break the loop in the same block of code
                    break;
                }
            }
            //if responds is not(!) found in the index 
            if (!found)
            {
                //display this 
                Console.WriteLine("your input is not on the list");
            }
            Console.ReadLine();

            //a list of strings that has at least two identical strings in the list
            List<string> someStrings = new List<string>() { "phone", "phone", "computer", "laptop" };

            //ask the user to select text to search for in the list
            Console.WriteLine("type a word like phone to search through the list, maybe theres two results");
            string same = Console.ReadLine();
            bool found1 = false;

            //creating a loop that iterates through the list and then displays the indicates of the iteam matching the user
            for (int y = 0; y < someStrings.Count - 1; y++)
            {
                //if what is typed in is equal to anything in the List (someStrings)
                if (same == someStrings[y])
                {
                    Console.WriteLine(y);
                    found1 = true;
                }
            }
            //added a loop to check if the user put in text that isnt on the list and, if they did, tells the user their input is not on the list
            if(!found1)
            {
                Console.WriteLine("what you type in isnt on the list");
            }
            Console.ReadLine();

            //created a list of strings that has at least two identical strings in the list
            List<string> notStrings = new List<string>() { "word", "crazy", "nonchalant", "crazy" };
            List<string> tStrings = new List<string>();

            //creating a foreach loop that evalutes each item in the list, and displays a message the string and whether or not it has already appeard
            foreach (string name in notStrings)
            {
                //this part of code is to check if there was any word that has repeated itself, if so print Console.WriteLine
                if (tStrings.Contains(name))
                {
                    Console.WriteLine("that word {0} already appears", name);
                }
                //making an else statement when determining if the any word has repeated again
                else
                {
                    tStrings.Add(name);
                    Console.WriteLine("that word {0} has not been seen", name);
                }
            }
            Console.ReadLine();
        }

    }
}
