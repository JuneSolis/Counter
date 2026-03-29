using System;
namespace Infinite_Counter
{
    public static class Infinite
    {
        static float A, B;
        static double C, D;
        public const string Version = "0.0.0.7", Creator = "May Wildflower",
            Title = "Counter (Infinite) v" + Version + " by " + Creator;
        static void Write(object obj)
        {
            Console.Out.WriteLine(obj);
            Console.Out.Flush();
        }
        public static void Main()
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Write("This counter runs indefinitely, press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            while (A != float.PositiveInfinity  && B != float.NegativeInfinity
                && C != double.PositiveInfinity && D != double.NegativeInfinity)
            {
                A++;
                B--;
                C++;
                D--;
                Write(A);
                Write(B);
                Write(C);
                Write(D);
            }
        }
    }
}