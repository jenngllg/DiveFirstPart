using System;
using System.Text.RegularExpressions;

namespace DiveFirstPart
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = System.IO.File.ReadAllLines(@"C:\Users\j.gullung\source\repos\DiveFirstPart\input.txt");
            int horizontalPosition = 0;
            int depth = 0;
            Regex filter = new(@"\w+"); // Equivalent to [a-zA-Z0-9_]
            string command;
            int units;

            for (int i = 0; i < commands.Length; i++)
            {
                var matches = filter.Matches(commands[i]);

                command = matches[0].Value;
                units = Int32.Parse(matches[1].Value);

                switch (command)
                {
                    case "forward":
                        horizontalPosition += units;
                        break;
                    case "up":
                        depth -= units;
                        break;
                    case "down":
                        depth += units;
                        break;
                }
            }
            Console.WriteLine($"horizontal position : {horizontalPosition} and depth : {depth}");
        }
    }
}
