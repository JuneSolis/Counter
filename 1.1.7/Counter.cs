using System;
public class Counter
{
    static sbyte A = sbyte.MinValue, B = sbyte.MaxValue;
    static byte C = byte.MinValue, D = byte.MaxValue;
    static short E = short.MinValue, F = short.MaxValue;
    static ushort G = ushort.MinValue, H = ushort.MaxValue;
    static int I = int.MinValue, J = int.MaxValue;
    static uint K = uint.MinValue, L = uint.MaxValue;
    static long M = long.MinValue, N = long.MaxValue;
    static ulong O = ulong.MinValue, P = ulong.MaxValue;
    static float Q = float.MinValue, R = float.MaxValue;
    static double S = double.MinValue, T = double.MaxValue;
    static bool ALimitReached = false, BLimitReached = false,
        CLimitReached = false, DLimitReached = false,
        ELimitReached = false, FLimitReached = false,
        GLimitReached = false, HLimitReached = false,
        ILimitReached = false, JLimitReached = false,
        KLimitReached = false, LLimitReached = false,
        MLimitReached = false, NLimitReached = false,
        OLimitReached = false, PLimitReached = false,
        QLimitReached = false, RLimitReached = false,
        SLimitReached = false, TLimitReached = false,
        AllLimitsReached = false;
    public const string Version = "1.1.7", Title = "Counter v" + Version;
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
        while (!AllLimitsReached)
        {
            if (A != sbyte.MaxValue)
            {
                A++;
                Write(A);
            }
            if (A == sbyte.MaxValue && !ALimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Write("A is " + sbyte.MaxValue);
                ALimitReached = true;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (B != sbyte.MinValue)
            {
                B--;
                Write(B);
            }
            if (B == sbyte.MinValue && !BLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Write("B is " + sbyte.MinValue);
                BLimitReached = true;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (C != byte.MaxValue)
            {
                C++;
                Write(C);
            }
            if (C == byte.MaxValue && !CLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                CLimitReached = true;
                Write("C is " + byte.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (D != byte.MinValue)
            {
                D--;
                Write(D);
            }
            if (D == byte.MinValue && !DLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                DLimitReached = true;
                Write("D is " + byte.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (E != short.MaxValue)
            {
                E++;
                Write(E);
            }
            if (E == short.MaxValue && !ELimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                ELimitReached = true;
                Write("E is " + short.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (F != short.MinValue)
            {
                F--;
                Write(F);
            }
            if (F == short.MinValue && !FLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                FLimitReached = true;
                Write("F is " + short.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (G != ushort.MaxValue)
            {
                G++;
                Write(G);
            }
            if (G == ushort.MaxValue && !GLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                GLimitReached = true;
                Write("G is " + ushort.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (H != ushort.MinValue)
            {
                H--;
                Write(H);
            }
            if (H == ushort.MinValue && !HLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                HLimitReached = true;
                Write("H is " + ushort.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (I != int.MaxValue)
            {
                I++;
                Write(I);
            }
            if (I == int.MaxValue && !ILimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                ILimitReached = true;
                Write("I is " + int.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (J != int.MinValue)
            {
                J--;
                Write(J);
            }
            if (J == int.MinValue && !JLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                JLimitReached = true;
                Write("J is " + int.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (K != uint.MaxValue)
            {
                K++;
                Write(K);
            }
            if (K == uint.MaxValue && !KLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                KLimitReached = true;
                Write("K is " + uint.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (L != uint.MinValue)
            {
                L--;
                Write(L);
            }
            if (L == uint.MinValue && !LLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                LLimitReached = true;
                Write("L is " + uint.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (M != long.MaxValue)
            {
                M++;
                Write(M);
            }
            if (M == long.MaxValue && !MLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                MLimitReached = true;
                Write("M is " + long.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (N != long.MinValue)
            {
                N--;
                Write(N);
            }
            if (N == long.MinValue && !NLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                NLimitReached = true;
                Write("N is " + long.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (O != ulong.MaxValue)
            {
                O++;
                Write(O);
            }
            if (O == ulong.MaxValue && !OLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                OLimitReached = true;
                Write("O is " + ulong.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (P != ulong.MinValue)
            {
                P--;
                Write(P);
            }
            if (P == ulong.MinValue && !PLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                PLimitReached = true;
                Write("P is " + ulong.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (Q != float.MaxValue)
            {
                Q++;
                Write(Q);
            }
            if (Q == float.MaxValue && !QLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                QLimitReached = true;
                Write("Q is " + float.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (R != float.MinValue)
            {
                R--;
                Write(R);
            }
            if (R == float.MinValue && !RLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                RLimitReached = true;
                Write("R is " + float.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (S != double.MaxValue)
            {
                S++;
                Write(S);
            }
            if (S == double.MaxValue && !SLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                SLimitReached = true;
                Write("S is " + double.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (T != double.MinValue)
            {
                T--;
                Write(T);
            }
            if (T == double.MinValue && !TLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                TLimitReached = true;
                Write("T is " + double.MinValue);
            }
            if (ALimitReached    && BLimitReached
                && CLimitReached && DLimitReached
                && ELimitReached && FLimitReached
                && GLimitReached && HLimitReached
                && ILimitReached && JLimitReached
                && KLimitReached && LLimitReached
                && MLimitReached && NLimitReached
                && OLimitReached && PLimitReached
                && QLimitReached && RLimitReached
                && SLimitReached && TLimitReached)
                AllLimitsReached = true;
        }
        if (AllLimitsReached)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Write("All limits reached!");
            Write("Press any key to restart!");
            Console.ReadKey();
            Main();
        }
    }
}