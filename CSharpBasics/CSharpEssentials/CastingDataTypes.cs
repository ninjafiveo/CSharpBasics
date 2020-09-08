using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class CastingDataTypes
    {
        public static void CastingData()
        {
            double myDouble = 10.5;
            int myInteger = 2;

            myDouble = myDouble + myInteger;
            Console.WriteLine("Implicit Cast: " + myDouble); //Implicit: C# Automatically Converts int to double

            myDouble = (double)7 / myInteger;
            Console.WriteLine("Explicit Cast: " + myDouble); //Explicitly Converts: C# Converts int to double
            // WITHOUT (double) answer is 3

            myDouble = 7 / myInteger;
            Console.WriteLine("Same problem without explicit Cast: " + myDouble);

            char myLetter = (char)65;
            Console.WriteLine("Cast integer: " + myLetter);

            int myAscii = (int)'A';
            Console.WriteLine("Cast Letter: " + myAscii);


            Console.ReadKey();
        }
    }
}
