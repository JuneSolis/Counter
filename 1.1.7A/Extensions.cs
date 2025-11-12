using System;
public static class Extensions
{
    public const StringComparison comp = StringComparison.OrdinalIgnoreCase;
    public static bool CaselessEq(this string a, string b) { return a.Equals(b, comp); }
    public static bool CaselessEnds(this string a, string b) { return a.EndsWith(b, comp); }
    public static bool CaselessContains(this string a, string b) { return a.IndexOf(b, comp) >= 0; }
    public static bool IsOtherVer(this string version)
    {
        if (version == null) return false;
        else if (version.CaselessEnds(".1")) return true;
        else if (version.CaselessEnds(".1.")) return true;
        else if (version.CaselessEnds("1.")) return true;
        else if (version.CaselessEnds("1")) return true;
        else if (version.CaselessEnds(".2")) return true;
        else if (version.CaselessEnds(".2.")) return true;
        else if (version.CaselessEnds("2.")) return true;
        else if (version.CaselessEnds("2")) return true;
        else if (version.CaselessEnds(".3")) return true;
        else if (version.CaselessEnds(".3.")) return true;
        else if (version.CaselessEnds("3.")) return true;
        else if (version.CaselessEnds("3")) return true;
        else if (version.CaselessEnds(".4")) return true;
        else if (version.CaselessEnds(".4.")) return true;
        else if (version.CaselessEnds("4.")) return true;
        else if (version.CaselessEnds("4")) return true;
        else if (version.CaselessEnds(".5")) return true;
        else if (version.CaselessEnds(".5.")) return true;
        else if (version.CaselessEnds("5.")) return true;
        else if (version.CaselessEnds("5")) return true;
        else if (version.CaselessEnds(".6")) return true;
        else if (version.CaselessEnds(".6.")) return true;
        else if (version.CaselessEnds("6.")) return true;
        else if (version.CaselessEnds("6")) return true;
        else if (version.CaselessEnds(".7")) return true;
        else if (version.CaselessEnds(".7.")) return true;
        else if (version.CaselessEnds("7.")) return true;
        else if (version.CaselessEnds("7")) return true;
        else if (version.CaselessEnds(".8")) return true;
        else if (version.CaselessEnds(".8.")) return true;
        else if (version.CaselessEnds("8.")) return true;
        else if (version.CaselessEnds("8")) return true;
        else if (version.CaselessEnds(".9")) return true;
        else if (version.CaselessEnds(".9.")) return true;
        else if (version.CaselessEnds("9.")) return true;
        else if (version.CaselessEnds("9")) return true;
        else return false;
    }
}