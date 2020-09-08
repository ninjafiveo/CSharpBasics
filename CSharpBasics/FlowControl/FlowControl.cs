﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics.FlowControl
{
    class FlowControl
    {
        public const int minimumAge = 13;
        public static int playerAge;
        public static string permission;


        public static void FCIfElse()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors, what is your age?");
            playerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You inputted {playerAge}.");

            if (playerAge >= minimumAge)
            {
                //if true run this block of code.
                Console.WriteLine("Excellent. You are old enough to get started.");
                //Add method you want to run here.
            }
            else
            {
                //if not true run this block of code
                Console.WriteLine($"Ouch. Sorry little lad. You must be at least {minimumAge} to play. Try again when you are older or ask your parents for permission.");
                //Add New Method
                FCElseIf();

            }

        }

        public static void FCElseIf()
        {
            Console.WriteLine("Do you have your parents permission to play? Enter Yes or No.");
            permission = Console.ReadLine();

            if (permission == "Yes")
            {
                //run a block of code
                Console.WriteLine("Great. Let's get started.");
                Console.ReadLine();
                //Input method here to start game.
            }
            else if (permission == "No")
            {
                //run block of code
                Console.WriteLine("Well that's too bad. Try again when you are old enough. Press enter to exit.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("I did not understand that answer. Please Try Again!");
                FCElseIf();
            }

        }
    }
}
