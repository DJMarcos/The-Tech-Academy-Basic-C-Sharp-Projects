﻿using System;

namespace assiingment_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the host a simple question with int
            Console.WriteLine("what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Final step adding all info gathered from host and using boolean logic
            Console.WriteLine("Qualified?");
            // comparing the info gathered with the requirements
            bool qualified = (age > 15 && DUI == false && tickets < 50);
            Console.WriteLine(qualified);
            Console.ReadLine();



        }
    }
}
