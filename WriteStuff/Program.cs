using System;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> strStack = new Stack<string>();
            string input;

            do
            {
                Console.WriteLine("What line to save?");
                input = Console.ReadLine();
                if (input != "") strStack.Push(input);
            } while (!(input == ""));

            File.WriteAllLines("Savefile.txt", strStack);
        }
    }
}
