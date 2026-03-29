using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace Counter
{
    public static class Starter
    {
        public const string Version = "1.0.0.5",
            Creator = "May Wildflower",
            Description = "Starter for Counters v0.0-1.1.8A",
            Title = "Starter v" + Version + " by " + Creator;
        static readonly List<string> Programs = new()
        {
            "Counter 0.0.exe", "Counter 0.1.exe", "Counter 0.2.exe", "Counter 0.4.exe",
            "Counter 0.5.exe", "Counter 0.6.exe", "Counter 0.7.exe", "Counter 0.8.exe",
            "Counter 0.9.exe", "Counter 1.0.0.exe", "Counter 1.0.1.exe", "Counter 1.0.2.exe",
            "Counter 1.0.3.exe", "Counter 1.0.4.exe", "Counter 1.0.5.exe", "Counter 1.0.6.exe",
            "Counter 1.0.7.exe", "Counter 1.0.8.exe", "Counter 1.0.9.exe", "Counter 1.1.0.exe",
            "Counter 1.1.1.exe", "Counter 1.1.2.exe", "Counter 1.1.3.exe", "Counter 1.1.4.exe",
            "Counter 1.1.5.exe", "Counter 1.1.6.exe", "Counter 1.1.7.exe", "Counter 1.1.8A.exe"
        };
        public static void Main()
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (string program in Programs)
                try
                {
                    Process.Start(Path.GetFullPath(program));
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine("Error starting program {0}: \n{1}", program, ex.Message);
                    Console.Out.Flush();
                    Console.ReadKey();
                    continue;
                }
        }
    }
}