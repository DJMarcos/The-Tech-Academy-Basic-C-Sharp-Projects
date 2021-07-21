using System;

namespace calling_methods_assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user a question and requireing them and reply with an answer
            Console.WriteLine("what number do you want to do the math operation on?");
            //whatever they type in, its going to be saved as answer
            int answer = Convert.ToInt32(Console.ReadLine());
            //this line of code will be whats going to display any answer after our method dose its thing
            //without this line of code your method will not function and getting no results
            int yourA = MyMath.Math1(answer);
            //doing a simple console.Readline to read whats going on
            Console.WriteLine(yourA);
            Console.ReadLine();

            // from here on out, in order to display the rest of our methods.
            //going to repeat the lines of code used to display the first method.
            Console.WriteLine("What number would you like to do the math operation on?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            int YourAB = MyMath.Math2(answer2);
            Console.WriteLine(YourAB);
            Console.ReadLine();

            Console.WriteLine("What number would you like to do the math opertion on, one last time lol");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            int YourAC = MyMath.Math3(answer3);
            Console.WriteLine(YourAC);
            Console.ReadLine();
        }

    }
}
