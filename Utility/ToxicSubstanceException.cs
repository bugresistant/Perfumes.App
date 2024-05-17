namespace Perfumes.App.Utility;

public class ToxicSubstanceException : Exception
{
    public ToxicSubstanceException(string message) : base(message)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.Gray;
    }
}