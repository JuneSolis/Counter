using System;
using System.Threading;
public static class Counter
{
    public const string Version = "1.1.8", 
        Creator = "May Wildflower",
        Title = "Counter v" + Version + " by " + Creator;
    public static void Write(object obj)
    {
        Console.Out.WriteLine(obj);
        Console.Out.Flush();
    }
    public static void Main(string[] args)
    {
        Console.Title = Title;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.Black;
        Write(Title);
        string arg = "1.1.7";
        if (args.LongLength <= 0)
            Write("No argument found, using default of \"1.1.7\".");
        else
            arg = args[0];
        VersionChoice(arg);
    }
    public static void VersionChoice(string arg)
    {
        if (arg.CaselessContains("1.1.7"))
        {
            Write("Running: Counter v" + Counter_1_1_7.Version);
            Thread.Sleep(1000);
            Counter_1_1_7.Main();
        }
        else if (arg.CaselessContains("1.1.6"))
        {
            Write("Running: Counter v" + Counter_1_1_6.Version);
            Thread.Sleep(1000);
            Counter_1_1_6.Main();
        }
        else if (arg.CaselessContains("1.1.5"))
        {
            Write("Running: Counter v" + Counter_1_1_5.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_5.Main();
        }
        else if (arg.CaselessContains("1.1.4"))
        {
            Write("Running: Counter v" + Counter_1_1_4.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_4.Main();
        }
        else if (arg.CaselessContains("1.1.3"))
        {
            Write("Running: Counter v" + Counter_1_1_3.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_3.Main();
        }
        else if (arg.CaselessContains("1.1.2"))
        {
            Write("Running: Counter v" + Counter_1_1_2.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_2.Main();
        }
        else if (arg.CaselessContains("1.1.1"))
        {
            Write("Running: Counter v" + Counter_1_1_1.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_1.Main();
        }
        else if (arg.CaselessContains("1.1.0"))
        {
            Write("Running: Counter v" + Counter_1_1_0.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_1_0.Main();
        }
        else if (arg.CaselessContains("1.0.9"))
        {
            Write("Running: Counter v" + Counter_1_0_9.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_9.Main();
        }
        else if (arg.CaselessContains("1.0.8"))
        {
            Write("Running: Counter v" + Counter_1_0_8.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_8.Main();
        }
        else if (arg.CaselessContains("1.0.7"))
        {
            Write("Running: Counter v" + Counter_1_0_7.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_7.Main();
        }
        else if (arg.CaselessContains("1.0.6"))
        {
            Write("Running: Counter v" + Counter_1_0_6.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_6.Main();
        }
        else if (arg.CaselessContains("1.0.5"))
        {
            Write("Running: Counter v" + Counter_1_0_5.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_5.Main();
        }
        else if (arg.CaselessContains("1.0.4"))
        {
            Write("Running: Counter v" + Counter_1_0_4.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_4.Main();
        }
        else if (arg.CaselessContains("1.0.3"))
        {
            Write("Running: Counter v" + Counter_1_0_3.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_3.Main();
        }
        else if (arg.CaselessContains("1.0.2"))
        {
            Write("Running: Counter v" + Counter_1_0_2.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_2.Main();
        }
        else if (arg.CaselessContains("1.0.1"))
        {
            Write("Running: Counter v" + Counter_1_0_1.InternalVersion);
            Thread.Sleep(1000);
            Counter_1_0_1.Main();
        }
        else if (arg.CaselessContains("1.0") && !arg.IsOtherVer())
        {
            Write("Running: Counter v" + Counter_1_0_0.Version);
            Thread.Sleep(1000);
            Counter_1_0_0.Main();
        }
        else if (arg.CaselessContains("9") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_9.Version);
            Thread.Sleep(1000);
            Counter_0_9.Main();
        }
        else if (arg.CaselessContains("8") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_8.Version);
            Thread.Sleep(1000);
            Counter_0_8.Main();
        }
        else if (arg.CaselessContains("7") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_7.Version);
            Thread.Sleep(1000);
            Counter_0_7.Main();
        }
        else if (arg.CaselessContains("6") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_6.Version);
            Thread.Sleep(1000);
            Counter_0_6.Main();
        }
        else if (arg.CaselessContains("5") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_5.Version);
            Thread.Sleep(1000);
            Counter_0_5.Main();
        }
        else if (arg.CaselessContains("4") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_4.Version);
            Thread.Sleep(1000);
            Counter_0_4.Main();
        }
        else if (arg.CaselessContains("3") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_3.Version);
            Thread.Sleep(1000);
            Counter_0_3.Main();
        }
        else if (arg.CaselessContains("2") && !arg.CaselessContains("1"))
        {
            Write("Running: Counter v" + Counter_0_2.Version);
            Thread.Sleep(1000);
            Counter_0_2.Main();
        }
        else if (arg.CaselessContains("0.1") || arg.CaselessEq("0.1."))
        {
            Write("Running: Counter v" + Counter_0_1.Version);
            Thread.Sleep(1000);
            Counter_0_1.Main();
        }
        else if (arg.CaselessEq("0.0") || arg.CaselessEq("0.0."))
        {
            Write("Running: Test v" + Counter_0_0.Version);
            Thread.Sleep(1000);
            Counter_0_0.Main();
        }
        else
        {
            Write("Running: Counter v" + Counter_1_1_7.Version);
            Thread.Sleep(1000);
            Counter_1_1_7.Main();
        }
    }
}