using System;

namespace calling_methods_assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what number do you want to do the math operation on?");
            int answer = Convert.ToInt32(Console.ReadLine());
            int yourA = MyMath.Math1(answer);
            Console.WriteLine(yourA);
            Console.ReadLine();


        }

    }
}
