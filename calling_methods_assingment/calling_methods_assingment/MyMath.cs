using System;
using System.Collections.Generic;
using System.Text;

//making methods that would make any sort of math operations
namespace calling_methods_assingment
{
    // in order to have these methods worl. Must have a PUbliC class in order for the other main program to access it.
    public class MyMath
    {
        //again in all methods in order to access it, must make it "public"
       public static int Math1(int answer)
        {
            // with this code we are telling the method to return(display)
            //the answer givin when asked a question and adding 2 at the end
            return (answer + 2);
        }
        //Int Math2(int answer)
        //telling the class that the method Math2 is going to be an int with an answer2 being an int as well
        public static int Math2(int answer2)
        {
            return (answer2 * 14);
        }
        public static int Math3(int answer3)
        {
            return (answer3 / 2);
        }
    }
}
