using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpBasics.ErrorHandling
{
    class TryCatchMeOutside
    {
        static public string documentPath = @"C:/Users/sekol_michael/source/repos/CSharpBasics/CSharpBasics/data.txt";
        public static void MyErrors()
        {
            try
            {
                using (StreamReader sr = File.OpenText(documentPath))
                {
                    Console.WriteLine($"The first line of the text is: {sr.ReadLine()}");
                    Console.WriteLine($"The second line of the text is: {sr.ReadLine()}");

                    sr.Close();

                    StreamWriter sw = new StreamWriter(documentPath);
                    Console.WriteLine("Give me a line to write.");
                    string swInput = Console.ReadLine();
                    sw.WriteLine(swInput);
                    Console.WriteLine("Give me a second line to write.");
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("Check and see if it worked.");
                    sw.Close();

                }
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine($"The file was not found: {e}");

                if (!File.Exists(documentPath))
                {
                    using (StreamWriter sw = File.CreateText(documentPath));

                }

                MyErrors();


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

