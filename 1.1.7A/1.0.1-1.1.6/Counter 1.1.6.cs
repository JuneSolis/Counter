using System;
public static class Counter_1_1_6
{
    public static sbyte A = sbyte.MinValue, B = sbyte.MaxValue;
    public static byte C = byte.MinValue, D = byte.MaxValue;
    public static short E = short.MinValue, F = short.MaxValue;
    public static ushort G = ushort.MinValue, H = ushort.MaxValue;
    public static int I = int.MinValue, J = int.MaxValue;
    public static uint K = uint.MinValue, L = uint.MaxValue;
    public static long M = long.MinValue, N = long.MaxValue;
    public static ulong O = ulong.MinValue, P = ulong.MaxValue;
    public static float Q = float.MinValue, R = float.MaxValue;
    public static double S = double.MinValue, T = double.MaxValue;
    public static bool ALimitReached = false, BLimitReached = false,
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
    public const string Version = "1.1.6", Title = "Counter v" + Version;
    public static void Write(object obj)
    {
        if (obj != null)
        {
            Console.Out.WriteLine(obj);
            Console.Out.Flush();
        }
    }
    public static void Main()
    {
        Console.Title = Title;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Write("A is " + sbyte.MaxValue);
                ALimitReached = true;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (B != sbyte.MinValue)
            {
                B--;
                Write(B);
            }
            if (B == sbyte.MinValue && !BLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Write("B is " + sbyte.MinValue);
                BLimitReached = true;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (C != byte.MaxValue)
            {
                C++;
                Write(C);
            }
            if (C == byte.MaxValue && !CLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                CLimitReached = true;
                Write("C is " + byte.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (D != byte.MinValue)
            {
                D--;
                Write(D);
            }
            if (D == byte.MinValue && !DLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                DLimitReached = true;
                Write("D is " + byte.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (E != short.MaxValue)
            {
                E++;
                Write(E);
            }
            if (E == short.MaxValue && !ELimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                ELimitReached = true;
                Write("E is " + short.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (F != short.MinValue)
            {
                F--;
                Write(F);
            }
            if (F == short.MinValue && !FLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                FLimitReached = true;
                Write("F is " + short.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (G != ushort.MaxValue)
            {
                G++;
                Write(G);
            }
            if (G == ushort.MaxValue && !GLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                GLimitReached = true;
                Write("G is " + ushort.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (H != ushort.MinValue)
            {
                H--;
                Write(H);
            }
            if (H == ushort.MinValue && !HLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                HLimitReached = true;
                Write("H is " + ushort.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (I != int.MaxValue)
            {
                I++;
                Write(I);
            }
            if (I == int.MaxValue && !ILimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                ILimitReached = true;
                Write("I is " + int.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (J != int.MinValue)
            {
                J--;
                Write(J);
            }
            if (J == int.MinValue && !JLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                JLimitReached = true;
                Write("J is " + int.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (K != uint.MaxValue)
            {
                K++;
                Write(K);
            }
            if (K == uint.MaxValue && !KLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                KLimitReached = true;
                Write("K is " + uint.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (L != uint.MinValue)
            {
                L--;
                Write(L);
            }
            if (L == uint.MinValue && !LLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                LLimitReached = true;
                Write("L is " + uint.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (M != long.MaxValue)
            {
                M++;
                Write(M);
            }
            if (M == long.MaxValue && !MLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                MLimitReached = true;
                Write("M is " + long.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (N != long.MinValue)
            {
                N--;
                Write(N);
            }
            if (N == long.MinValue && !NLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                NLimitReached = true;
                Write("N is " + long.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (O != ulong.MaxValue)
            {
                O++;
                Write(O);
            }
            if (O == ulong.MaxValue && !OLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                OLimitReached = true;
                Write("O is " + ulong.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (P != ulong.MinValue)
            {
                P--;
                Write(P);
            }
            if (P == ulong.MinValue && !PLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PLimitReached = true;
                Write("P is " + ulong.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (Q != float.MaxValue)
            {
                Q++;
                Write(Q);
            }
            if (Q == float.MaxValue && !QLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                QLimitReached = true;
                Write("Q is " + float.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (R != float.MinValue)
            {
                R--;
                Write(R);
            }
            if (R == float.MinValue && !RLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                RLimitReached = true;
                Write("R is " + float.MinValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (S != double.MaxValue)
            {
                S++;
                Write(S);
            }
            if (S == double.MaxValue && !SLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                SLimitReached = true;
                Write("S is " + double.MaxValue);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (T != double.MinValue)
            {
                T--;
                Write(T);
            }
            if (T == double.MinValue && !TLimitReached)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
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
            {
                AllLimitsReached = true;
            }
        }
        if (AllLimitsReached)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Write("All limits reached!");
            Write("Press any key to restart!");
            Console.ReadKey(true);
            Main();
        }
    }
}