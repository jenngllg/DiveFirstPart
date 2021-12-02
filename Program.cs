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
            string command;
            int units;

            for (int i = 0; i < commands.Length; i++)
            {
                string[] commandAndUnit = commands[i].Split(' ');
                command = commandAndUnit[0];
                units = Int32.Parse(commandAndUnit[1]);

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
