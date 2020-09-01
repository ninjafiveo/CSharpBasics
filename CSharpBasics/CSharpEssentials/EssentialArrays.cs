using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharpBasics.CSharpEssentials
{
    public class EssentialArrays
    {
        ///Arrays (Container where you know the number of elements you'll need)
        /// 1. Creating Arrays
        /// Get/Set Values
        /// Looping
        /// .
        /// .
        /// Lists (Container where you DO NOT know the number of elements you'll need)
        /// 
        /// 2D Arrays
        /// Grid
        /// Jagged Arrays

        //Arrays - Declare Type

        public static void MyArrays()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 130;
            numbers[2] = 450;
            numbers[3] = 27364;
            numbers[4] = 1193;

            Console.WriteLine(numbers[3]);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array number {i} = {numbers[i]}");
            }

            //alternate loop
            int startAtZero = 0;
            foreach(int Ninja in numbers)
            {
                Console.WriteLine($"Here is another way of writing the array number {startAtZero}: {Ninja}");
                startAtZero++;
            }

        }

        public static void StringArray()
        {
            string[] ninjaNames = new string[5]
            {
                "Ueshiba", "Hitogoroshi", "Kaizen", "Goshin", "Fred"
            };

            int startAtZero = 0;
            foreach (string Ninja in ninjaNames)
            {
                Console.WriteLine($"Here is another way of writing the array number {startAtZero}: {Ninja}");
                startAtZero++;
            }
        }

        public static void MyLists()
        {
            //need to add using System.Collections.Generic; if it is not already there.

            List<int> ninjaAges = new List<int>();
            ninjaAges.Add(87);
            ninjaAges.Add(8);
            ninjaAges.Add(7);
            ninjaAges.Add(99);
            ninjaAges.Add(105);
            Console.WriteLine("The age in the 2 spot is " + ninjaAges[2]);

            for (int i = 0; i < ninjaAges.Count; i++) //You have to use .Count here.
            {
                Console.WriteLine($"Ninja age  #{i} = {ninjaAges[i]}");
            }
            Console.WriteLine();

            ///This is how you remove a number. 
            ninjaAges.RemoveAt(2); //You can also do the .Remove and identify the value that matches, but .RemoveAt targets the index.
            Console.WriteLine(ninjaAges[2]);
            for (int i = 0; i < ninjaAges.Count; i++) //You have to use .Count here.
            {
                Console.WriteLine($"Ninja age  #{i} = {ninjaAges[i]}");
            }
            Console.WriteLine("The age in the 2 spot is " + ninjaAges[2]);
            Console.WriteLine();

        }

        public static void CreateGrid()//multidimensional array
        {
            int width = 5;
            int height = 5;
            int[,] myGrid = new int[width, height];

            myGrid[0, 0] = 1;
            myGrid[0, 1] = 2;
            myGrid[0, 2] = 3;
            myGrid[0, 3] = 4;
            myGrid[0, 4] = 5;
            myGrid[2, 0] = 13;
            myGrid[2, 1] = 23;
            myGrid[2, 2] = 33;
            myGrid[2, 3] = 43;
            myGrid[2, 4] = 53;
            myGrid[4, 0] = 131;
            myGrid[4, 1] = 231;
            myGrid[4, 2] = 331;
            myGrid[4, 3] = 431;
            myGrid[4, 4] = 531;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(myGrid[x, y] + ", ");
                }
                Console.WriteLine();

            }

        }


    }
}

/// Notes: https://www.youtube.com/watch?v=RQ0JHMGiobo
