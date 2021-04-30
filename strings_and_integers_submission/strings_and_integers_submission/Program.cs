using System;
using System.Collections.Generic;

namespace strings_and_integers_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //using a try/catch to let user know of any known errors that could happen without the program go crazy
            try
            {
                //creating a list of int to divide any number the user input
                List<int> newString = new List<int>() { 4, 8, 5, 10, 20, 2 };
                Console.WriteLine("Please choose a number that can can be divided by any number in the list");
                int number = Convert.ToInt32(Console.ReadLine());
                //creating a loop to go through all the numbers in the list to divide by any number the user inputs
                foreach (int pro in newString)
                {
                    //creating a new varible to store any answer to display on the console
                    int bro = pro / number;
                    Console.WriteLine(bro);
                }
                Console.ReadLine();
            }
            //making catch block of codes to give out an message to any possible errors that could acur
            catch (FormatException ex)
            {
                Console.WriteLine("please use a correct format and not a string");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("please do not divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //adding a finally message to display to let the user know they have got out of the try/catch basically ending the program
            finally
            {
                Console.WriteLine("good thing is, we emerged from the try/catch");
            }
            Console.ReadLine();
        }
    }
}
