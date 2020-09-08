using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCharacterClass();
        }

        static void MyCharacterClass()
        {
            CharacterClass oldNinja = new CharacterClass();
            CharacterClass mediumSamurai = new CharacterClass();
            CharacterClass youngNinja = new CharacterClass();

            oldNinja.CharacterName = "Ninjafiveo";
            oldNinja.CharacterLevel = 105;
            oldNinja.CharacterRace = "Human";
            oldNinja.HitPoints = 5000;
            oldNinja.CharClass = "Mage";
            oldNinja.InGuild = true;
            oldNinja.CharacterSelect();
            Console.WriteLine();

            mediumSamurai.CharacterName = "Bob";
            mediumSamurai.CharacterLevel = 55;
            mediumSamurai.CharacterRace = "Orc";
            mediumSamurai.HitPoints = 5000;
            mediumSamurai.CharClass = "Warrior";
            mediumSamurai.InGuild = true;
            mediumSamurai.CharacterSelect();
            Console.WriteLine();

            youngNinja.CharacterName = "Fred";
            youngNinja.CharacterLevel = 30;
            youngNinja.CharacterRace = "Orc";
            youngNinja.HitPoints = 5000;
            youngNinja.CharClass = "Warrior";
            youngNinja.InGuild = false;
            youngNinja.CharacterSelect();
            Console.WriteLine();

        }
        static void myHoomans()
        {
            HoomanClass MrSekol = new HoomanClass();
            MrSekol.age = 99;
            MrSekol.dogName = "Mozzy";
            MrSekol.hasDog = true;
            MrSekol.name = "Michael";
            MrSekol.Greeting();

            HoomanClass Gaveeen = new HoomanClass();
            Gaveeen.age = 23;
            Gaveeen.hasDog = false;
            Gaveeen.name = "NotRudiak";
            Gaveeen.Greeting();



        }
        static void MyString()
        {
            // This is a comment.
  
            Console.Write("What year were born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string myString1 = "This is my first String.";
            string theTruth = "The last thing a ninja would do is admit to being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"This is a change. {theTruth}, {theLie}");

        }
        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob the Builder";
            bool awesome = true;
            char grade = 'F'; // Chars are single characters. requires single quotes. 'A'
            float altitude = 90.265141f;  //float requires 'f' at the end.
            double bankBalance = -4000000;
            decimal pi = 3.14159265359M; // decimal requires an M

            /// OutPut 
            /// 
            Console.WriteLine($"int = {myAge}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {awesome}.");
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"float = {altitude}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"decimal = {pi}.");

        }
        static void InputTypes()
        {
            //DataTypes();
            Console.WriteLine("Enter Number One");
            //string myName = Console.ReadLine();
            decimal numberOne = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"You entered: {numberOne}");

            Console.WriteLine("Enter Number Two");
            decimal numberTwo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"You entered {numberOne} & {numberTwo}");

            //Addition
            Console.WriteLine($"Addition: {numberOne} + {numberTwo} = {numberOne + numberTwo}");
            //Subtraction
            Console.WriteLine($"Subtraction: {numberOne} - {numberTwo} = {numberOne - numberTwo}");
            //Multiplication
            Console.WriteLine($"Multiplication: {numberOne} * {numberTwo} = {numberOne * numberTwo}");
            //Division
            Console.WriteLine($"Division: {numberOne} / {numberTwo} = {numberOne / numberTwo}");
            //Remainder (Modulus)
            Console.WriteLine($"Modulus: {numberOne} % {numberTwo} = {numberOne % numberTwo}");

            //Increment
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"Increment: The increment of {++numberOne} is {numberOne}");
            Console.WriteLine($"numberOne++ is the same as numberOne = numberOne + 1. See here: {numberOne} is {numberOne = numberOne + 1} ");
            //Decrement
            Console.WriteLine($"Decrement: The deccrement of {numberTwo--} is {numberTwo}");
            Console.WriteLine($"Decrement: The deccrement of {--numberTwo} is {numberTwo}");

            decimal centeredPolygonal = ((((numberOne * numberTwo) / 2) * (numberTwo - 1)) + 1);

            Console.WriteLine($"The centered polygonal \nof {numberOne} & {numberTwo} is: {centeredPolygonal}");

            
        }
        static void CastingTypes()
        {
            double myDouble = 10.5;
            int myInteger = 2;

            myDouble = myDouble + myInteger;
            Console.WriteLine($"Implicit cast: {myDouble}"); //Implicit Cast: C# Automatically Converts int to double

            myDouble = (double)7 / myInteger;
            Console.WriteLine($"Explicit cast: {myDouble}"); //Explicit Cast: C# If forced to Convert int to double
                                                             //Without (double) answer is 3
            myDouble = 7 / myInteger;
            Console.WriteLine($"Without explicit cast: {myDouble}");

            char myLetter = (char)65;
            Console.WriteLine($"Cast integer: {myLetter}");


            int myAscii = (int)'B';
            Console.WriteLine($"Cast letter: {myAscii}");

            Console.ReadKey();

        }
    }
}