using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{

    public class CommonDataTypes1
    {
        /// Primative Types
        //Integral Numbers
        public byte num1 = 235;            // 0 - 255
        short myInt16 = 32000;      //-32768 to 32768
        int myInt32 = 2100000000;   //-2.1B to 2.1B
        int myAge = 43;             //Whole Numbers
        long myInt64;               // Whole Numbers but double the size of int.

        //Real Numbers
        float myChange = 1.05f;     //32 bit precision. Must be followed by an "f"
        double myInterest = 1.0890049483839405498598;   //64 bit precision
        decimal myGiantNumber = 999999999999999; // and a lot bigger than that. 7.9 x 10 to the 28 power. Twice the size of a float

        //Character
        char myGrade = 'A';       //Single Characters.. - Single quotes

        //Boolean
        bool isAwesome = true;  // True or False... on off.

        /// OVERFLOWING - Going beyond the bounds of the data type.
        //byte myByteNumber = 255;
        //myByteNumber = 255 + 1; 256 is beyond the bounds of a byte.
        ///.
        ///checked
        ///{
        ///byte number = 255;
        ///number = number +1;
        ///}



        

        /// NON-PRIMATIVE TYPES
        /// 

        //String
        public string myName = "Captain Awesome";      //Words... letters...

        //Array

        //Enum

        //Class

        ///Misc.
        const float Pi = 3.14f; // const = value never changed. 

        /// Identifiers cannot start with a number
        /// string 1age = 20; <-- not value. cannot start with number. Can be "oneAge"
        ///
        /// Cannot have whitespace
        /// string first name = "Michael"; // This is not valid code.
        /// string firstname = "Michael" // is acceptable. 
        /// .
        /// Cannot use a reserved keyword
        /// int int = 50; <-- not acceptable.
        /// int @int = 50; <-- acceptable... but don't do this. Come up with something else. Horrible description.
        /// .
        /// Use meaningful name
        /// string fn; // not useful
        /// string firstName; // useful and descript.
        /// 

        ///Notation & Naming Conventions
        ///Camel Case: firstName; <-- use this for local variables
        ///Pascal Case: FirstName; <-- use this for constants.
        ///Hungarian Notation strFirstname; <-- Not used in C#... I mean you can, but not SOP.


        // C# Keywords are always lowercase.
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types




    }
}
