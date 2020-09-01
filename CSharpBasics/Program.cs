using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using CSharpBasics.CSharpEssentials;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args) //Void = Method does not return value. Just contains code. //Main = Entry point of program. All Code Starts here. 
        {
            //Console.WriteLine("Hello World!");
            //MyString();
            //RunHooman();
            //Console.ReadLine();

            //Console.WriteLine();
            //RunCommonDataTypes();
            //RunArrays();

            //RunMath();
            //RunBasicRules();
            RunCastingDataTypes();


 
        }

        static void MyString()
        {
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

        static void RunHooman()
        {
            hoomanClass mrSekol = new hoomanClass(); //object created.
            mrSekol.DogName = "Mozzy";
            mrSekol.Name = "Captain Awesome";
            mrSekol.Age = 178;
            mrSekol.HasDog = true;

            //Run Method
            mrSekol.Greeting();

            hoomanClass mrSmith = new hoomanClass();
            mrSmith.HasDog = false;
            mrSmith.Name = "John Frowny Face Smith";
            mrSmith.Age = 50;

            mrSmith.Greeting();
        }

        static void RunCommonDataTypes()
        {
            CommonDataTypes1 myData = new CommonDataTypes1();
            /// Need to change access modifies change what can be accessed. 
            myData.myName = "Ninja";
            Console.WriteLine(myData.myName);

        }

        static void RunArrays()
        {
            //EssentialArrays.MyArrays(); // You can just pull in the existing value of the class without creating an object. 
            //EssentialArrays.StringArray();
            //EssentialArrays.MyLists();
            EssentialArrays.CreateGrid();
        }

        static void RunMath()
        {
            MathOperators.Arithmetic();
        }

        static void RunBasicRules()
        {
            BasicRules.SomeBasics();
        }

        static void RunCastingDataTypes()
        {
            CastingDataTypes.CastingData();
        }
    }
}
