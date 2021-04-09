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
            // begin asking host for an answer
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express, Have a good day");
            }
            else
            {
                // simple question inputs for host
                Console.WriteLine("Please enter the package width");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());
                // multiply answers givin
                int HWL = width * height * length;
                //checking to see to talt amount is greater then 50
                if (HWL > 50)
                {
                    Console.WriteLine("sorry, package is too large. Goodbye.");
                }
                else
                {
                    //last divide total amount
                    int total = HWL * weight;
                    int last = total / 100;
                    Console.WriteLine("Your estimated total for shipping this package is : " + last);
                    Console.ReadLine();
                }
            }
        }
    }
}
