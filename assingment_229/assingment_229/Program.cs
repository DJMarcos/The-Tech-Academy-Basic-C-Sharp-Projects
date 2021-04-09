using System;

namespace assingment_229
{
    class Program
    {
        static void Main(string[] args)
        {
            // start by asking the host a simple bool question for age
            Console.WriteLine("hellooo, lets see if you are eliigble, how old are you?");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool Answer = answer == 21;

            do
            {
                switch (answer)
                {
                    // adding different cases for the right age to be eligible
                    case 18:
                        Console.WriteLine("you said your 18, your not eligible.");
                        Console.WriteLine("how old are you?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("you said your 15, your not eligible.");
                        Console.WriteLine("how old are you?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("you said your 17, your not eligible.");
                        Console.WriteLine("how old are you?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("you are old enough to work here");
                        Console.WriteLine("how old are you?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    // default would be anything over 21 should be eligible
                    default:
                        Console.WriteLine("you are not old enough to work here.");
                        Console.WriteLine("how old are you?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!Answer);
            Console.ReadLine();
        }
    }
}
