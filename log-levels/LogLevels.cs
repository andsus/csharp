using System;
using System.Text.RegularExpressions;

static class LogLine
{

    private static string REGEX => @"\[(?<level>[A-Z]+)\]:\s(?<message>.+)";

    private static Match matcher(string logLine) => Regex.Match(logLine, REGEX);

    public static string Message(string logLine)
    {
        return matcher(logLine).Groups["message"].Captures[0].Value.Trim();
        // return logLine[(logLine.IndexOf(':') + 1)..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        return matcher(logLine).Groups["level"].Captures[0].Value.ToLower();
        // return logLine[1..logLine.IndexOf(']')].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})"; 
    }

}
