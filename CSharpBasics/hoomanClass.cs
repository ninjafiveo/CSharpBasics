using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class hoomanClass
    {
        /// this is a class sample
        ///classes have fields & methods.
        ///fields: Name, Age, HasPet
        ///methods: Walk(), Sleep(), GetPet()
        ///Can create objects off the blueprint (Class)
        ///

        public string Name;
        public int Age;
        public bool HasDog;
        public string DogName;

        public void Greeting()
        {
            if(HasDog == true)
            {
                Console.WriteLine("Hello. Who's a good pupper? " + DogName + " is!");
            }
            else
            {
                Console.WriteLine($"Hello. I am a sad Hooman I have no pupper.");
            }
            
        }

        public int Calc(int x, int y)
        {
            //void - no value returned
            //if you are going to return something you have to declare the value type... int, string, bool etc.

            int myNumber = x + y;
            return myNumber;
        }
        
    }
}

/// Access Modifiers  - A way for us to tell the code where we can access the information
/// 1. Public - Can access from the assembly
/// 2. Private
/// 3. Protected
/// 4. Internal
/// 5. Protected internal
/// 6. Private Protected
