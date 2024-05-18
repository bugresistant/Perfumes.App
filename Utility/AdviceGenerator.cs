namespace Perfumes.App.Utility;

public static class AdviceGenerator
{
    // Pseudorandom generator based on seed (I've got no idea how the Random class works I just copied it from somewhere ssry)
    private static readonly Random random = new Random();

    private static readonly string[] advices = new string[]
    {
        "I would not recommend to drink it. I mean, seriously.",
        "Maybe you should take a shower instead of trying to cover up your odor with perfume...",
        "Don't worry about it, cuz it smells not that bad, perhaps.",
        "Next time try to add something that not stinks.",
        "***ADVICE IS IN CONSTRUCTION, COME BACK LATER***."
    };
    public static void GiveRandomAdvice() 
    {
        Console.WriteLine("\nA piece of advice for today:");
        int adviceIndex = random.Next(advices.Length-1); 
        Console.WriteLine(advices[adviceIndex] + '\n');
    }
}