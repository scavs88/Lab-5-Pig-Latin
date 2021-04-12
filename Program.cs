using System;

namespace Pig_Latin_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to be translated");
            string input = Console.ReadLine();
            Indexter(input);

        }






        static string Indexter(string input)
        {

            int a = input.IndexOf("a");

            int e = input.IndexOf("e");

            int i = input.IndexOf("i");

            int o = input.IndexOf("o");

            int u = input.IndexOf("u");


            if (a == 0 || e == 0 || i == 0 || o == 0 || u == 0)// first letter vowel 
            {
                Console.WriteLine($"{input}way");
            }
            else //first letter consonant
            {
                
                for (i = 0; i < input.Length; i++)
                {
                    Console.WriteLine(input.Substring(i, 1));
                    string letter = input.Substring(i, 1);

                    if ("a" == letter || "e" == letter || "i" == letter || "o" == letter || "u" == letter)
                    {

                        Console.WriteLine(letter + "ay");

                    }
                }


            }


             return "";


        }







    }
}
