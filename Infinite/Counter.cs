using System;
namespace Infinite_Counter
{
    public static class Infinite
    {
        public static float A, B;
        public static double C, D;
        public const string Version = "0.0.0.6", Creator = "June Solis",
            Title = "Counter (Infinite) v" + Version + " by " + Creator;
        public static void Write(object obj)
        {
            if (obj != null)
            {
                Console.Out.WriteLine(obj);
                Console.Out.Flush();
            }
        }
        public static void Main(string[] _)
        {
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Write("This counter runs indefinitely, press any key to continue.");
            Console.ReadKey(true);
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