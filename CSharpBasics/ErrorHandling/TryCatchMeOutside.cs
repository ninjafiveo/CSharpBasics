using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpBasics.ErrorHandling
{
    class TryCatchMeOutside
    {
        public static void MyErrors()
        {
            try
            {
                using (StreamReader sr = File.OpenText("bob.txt"))
                {
                    Console.WriteLine($"The first line of the text is: {sr.ReadLine()}");
                    Console.WriteLine($"The second line of the text is: {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: {e}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Directory was not found: {e}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"File Could Not Be Opened: {e}");
            }
        }

    }
}

//https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netcore-3.1

