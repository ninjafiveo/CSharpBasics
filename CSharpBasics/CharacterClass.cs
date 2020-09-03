using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class CharacterClass
    {
        public string CharacterName; 
        public int CharacterLevel; 
        public string CharacterRace; 
        public double HitPoints; 
        public string CharClass;
        public bool InGuild;

        public void CharacterSelect()
        {
            if (CharacterLevel >= 100)
            {
                Console.WriteLine($"Welcome {CharacterName}. You are mighty {CharClass}, of the {CharacterRace} people. You must be a hard one to defeat with {HitPoints} hit points. ");
            }
            else if (CharacterLevel >= 50)
            {
                Console.WriteLine($"Welcome {CharacterName}. You are a growing young {CharClass}. The {CharacterRace} people must be looking forward to your development. Some day you'll be a hard one to defeat.");
            }
            else
            {
                if (InGuild == true)
                {
                    Console.WriteLine($"Look at you little {CharacterName}. Already in a programming guild. You'll go far.");
                }
                else
                {
                    Console.WriteLine($"You're in trouble {CharacterName}. It is hard to survive on your own out here. ");
                }
            }
        }
    }
}
