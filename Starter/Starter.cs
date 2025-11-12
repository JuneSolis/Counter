using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace Counter
{
    public static class Starter
    {
        public const string Version = "1.0.0.4",
            Creator = "June Solis",
            Description = "Starter for Counters v0.0-1.1.7A",
            Title = "Starter v" + Version + " by " + Creator;
        public static List<string> Programs = new()
        {
            "Counter 0.0.exe", "Counter 0.1.exe", "Counter 0.2.exe", "Counter 0.4.exe",
            "Counter 0.5.exe", "Counter 0.6.exe", "Counter 0.7.exe", "Counter 0.8.exe",
            "Counter 0.9.exe", "Counter 1.0.0.exe", "Counter 1.0.1.exe", "Counter 1.0.2.exe",
            "Counter 1.0.3.exe", "Counter 1.0.4.exe", "Counter 1.0.5.exe", "Counter 1.0.6.exe",
            "Counter 1.0.7.exe", "Counter 1.0.8.exe", "Counter 1.0.9.exe", "Counter 1.1.0.exe",
            "Counter 1.1.1.exe", "Counter 1.1.2.exe", "Counter 1.1.3.exe", "Counter 1.1.4.exe",
            "Counter 1.1.5.exe", "Counter 1.1.6.exe", "Counter 1.1.7A.exe"
        };
        public static void Main(string[] _)
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (string program in Programs)
            {
                try
                {
                    Process.Start(Path.GetFullPath(program));
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine("Error starting program {0}: \n{1}", program, ex.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}