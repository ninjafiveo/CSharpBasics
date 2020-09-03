using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class MathOperators
    {

        public static void Arithmetic()
        {
            // + - * / % pow
            Console.WriteLine("Please enter the first number for some math: ");
            decimal numberOne = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please enter the second number for some math: ");
            decimal numberTwo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine();

            //Addition
            Console.WriteLine($"Addition: {numberOne} + {numberTwo} = {numberOne + numberTwo}");
            //Subtraction
            Console.WriteLine($"Subtraction: {numberOne} - {numberTwo} = {numberOne - numberTwo}");
            //Multiplication
            Console.WriteLine($"Multiplication: {numberOne} * {numberTwo} = {numberOne * numberTwo}");
            //Division
            Console.WriteLine($"Division: {numberOne} / {numberTwo} = {numberOne / numberTwo}");
            //Modulus
            Console.WriteLine($"Modulus: The remainder of {numberOne} / {numberTwo} = {numberOne % numberTwo}");
            //Increment
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"Decrement: The decrement of {numberTwo--} is {numberTwo}");
            Console.WriteLine($"Decrement: The decrement of {numberTwo--} is {numberTwo}");

            //Applying it to Centered Polygonal Number
            decimal centerPolygonal = ((((numberOne * numberTwo) / 2) * (numberTwo - 1)) + 1);
            Console.WriteLine($"The centered polygonal number of {numberOne} and {numberTwo} is: {centerPolygonal}");

            Console.ReadLine();
        }
    }
}

///https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators

