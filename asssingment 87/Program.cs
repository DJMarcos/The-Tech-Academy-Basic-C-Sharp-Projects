using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssingment_87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number to multiplay by 50");
            int input = Convert.ToInt32(Console.ReadLine());
            double NumL = input * 50;
            Console.WriteLine("Your number times 50 is: " + NumL );
            Console.ReadLine();

            Console.WriteLine("type a number to add 25");
            int Add = Convert.ToInt32(Console.ReadLine());
            int Resu = Add + 25;
            Console.Write("Your number plus 25 is: " + Resu);
            Console.ReadLine();

            Console.WriteLine("type a number to divide by 12.5");
            double NuM = Convert.ToInt32(Console.ReadLine());
            double quotient = NuM / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.ReadLine();

            Console.WriteLine("type a number to see if it's greater than 50");
            int User = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = User > 50;
            Console.WriteLine("Your number is greater than 50: " + trueOrFalse);
            Console.ReadLine();

            Console.WriteLine("type a number to divid by 7 to see the remainder");
            int Div = Convert.ToInt32(Console.ReadLine());
            int remainer = Div % 7;
            Console.WriteLine("The remainer is: " + remainer);
            Console.ReadLine();
        }
    }
}
