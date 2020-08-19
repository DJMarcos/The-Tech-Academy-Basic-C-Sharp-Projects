using System;

namespace assiingment_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Have you ever had a DUI?");
            bool AnswerTrue = true;
            bool AnswerFalse = false;
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qualified?");
            bool qualified = (age > 15 && AnswerFalse == false && tickets < 1);
            Console.WriteLine(qualified);
            Console.ReadLine();



        }
    }
}
