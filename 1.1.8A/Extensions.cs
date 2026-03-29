using System;
public static class Extensions
{
    public static bool CaselessEq(this string a, string b) => a.Equals(b, StringComparison.OrdinalIgnoreCase);
    public static bool CaselessEnds(this string a, string b) => a.EndsWith(b, StringComparison.OrdinalIgnoreCase);
    public static bool CaselessContains(this string a, string b) => a.IndexOf(b, StringComparison.OrdinalIgnoreCase) >= 0;
    public static bool IsOtherVer(this string version) => version switch
    {
        null => false,
        _ => version.CaselessEnds(".1") || version.CaselessEnds(".1.") 
        || version.CaselessEnds("1.") || version.CaselessEnds("1") 
        || version.CaselessEnds(".2") || version.CaselessEnds(".2.")
        || version.CaselessEnds("2.") || version.CaselessEnds("2") 
        || version.CaselessEnds(".3") || version.CaselessEnds(".3.") 
        || version.CaselessEnds("3.") || version.CaselessEnds("3") 
        || version.CaselessEnds(".4") || version.CaselessEnds(".4.") 
        || version.CaselessEnds("4.") || version.CaselessEnds("4") 
        || version.CaselessEnds(".5") || version.CaselessEnds(".5.") 
        || version.CaselessEnds("5.") || version.CaselessEnds("5") 
        || version.CaselessEnds(".6") || version.CaselessEnds(".6.") 
        || version.CaselessEnds("6.") || version.CaselessEnds("6") 
        || version.CaselessEnds(".7") || version.CaselessEnds(".7.") 
        || version.CaselessEnds("7.") || version.CaselessEnds("7") 
        || version.CaselessEnds(".8") || version.CaselessEnds(".8.") 
        || version.CaselessEnds("8.") || version.CaselessEnds("8") 
        || version.CaselessEnds(".9") || version.CaselessEnds(".9.")
        || version.CaselessEnds("9.") || version.CaselessEnds("9"),
    };
}