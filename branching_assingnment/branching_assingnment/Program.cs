using System;

namespace branching_assingnment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package Express. Please follow the instructions below");
            Console.ReadLine();

            // branching is needed to determine a price
            Console.WriteLine("Please enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express, Have a good day");
            }
            else
            {
                Console.WriteLine("Your package is valid");
            }
            Console.ReadLine();

            //using branching again to check for price
            Console.WriteLine("Please enter the package width");
            int width = Convert.ToInt32(Console.ReadLine());

            if (width > 50)
            {
                Console.WriteLine("Package is too big for Package Express");
            }
            else
            {
                Console.WriteLine("Your package checks out");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the package height");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height > 50)
            {
                Console.WriteLine("Package is too height for transport");
            }
            else
            {
                Console.WriteLine("Your package checks out");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the package length");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length > 50) 
            {
                Console.WriteLine("Package is too heavy yoo");
            }
            else
            {
                Console.WriteLine("Your package length checks out");
            }
            Console.ReadLine();

            // as for the final step multiplying and dividing answers givin
            int HWL = width * height * length;
            int total = HWL * weight;
            int last = total / 100;
            Console.WriteLine("Your estimated total for shipping this package is : " + last);
            Console.ReadLine();



        }
    }
}
