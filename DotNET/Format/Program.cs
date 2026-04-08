using System;

class Program
{
    private const string Line = "------------------------------";

    string ReturnValue(string s)
    {
        return s;
    }

    static void UpperFormat()
    {
        Program program = new Program();
        string result = program.ReturnValue("This is a string.");

        Console.WriteLine($"""
        {Line}
        Before : {result}
        After Upper : {$"[{result.ToUpper()}]"}
        After Lower : {$"[{result.ToLower()}]"}
        """);
    }

    static void TrimFormat()
    {
        Program program = new Program();
        string result = program.ReturnValue("      The Trim method string.     ");

        Console.WriteLine($"""
        {Line}
        Before : {result}
        After Normal Trim : {$"[{result.Trim()}]"}
        After Trim Start  : {$"[{result.TrimStart()}]"}
        After Trim End    : {$"[{result.TrimEnd()}]"}
        """);
    }
    
    static void ReplaceFormat()
    {
        Program program = new Program();
        string result = program.ReturnValue("The Replace method string.");

        Console.WriteLine($"""
        {Line}
        Before : {result}
        After Replace : {$"[{result.Replace("Replace", "Replaced")}]"}
        """);
    }

    static void SearchFormat()
    {
        Program program = new Program();
        string result = program.ReturnValue("The Search method string.");
        Console.WriteLine($"""
        {Line}
        Before : {result}
        Get Search : {$"[{result.Contains("Search")}]"}
        Get Search : {$"[{result.Contains("search")}]"}
        """);
    }

    static void Main()
    {
        UpperFormat();
        TrimFormat();
        ReplaceFormat();
        SearchFormat();
    }
}