﻿namespace Perfumes.App.Utility;

public static class AdviceGenerator
{
    // Pseudorandom generator based on seed (I've got no idea how it works I just copied it from somewhere ssry)
    private static readonly Random random = new Random();
    private static readonly string[] advices = new string[] {
        "I would not recommend to drink it. I mean, seriously.",
        "Maybe you should take a shower instead of trying to cover up your odor with perfume...",
        "It smells not that bad, perhaps.",
        "Next time try to add something that not stinks.",
        "It's like vodka, but odoriferous, right?",
        "***ADVICE IS IN CONSTRUCTION, COME BACK LATER***."
    };
    public static void GiveRandomAdvice() 
    {
        int adviceIndex = random.Next(advices.Length-1); 
        Console.WriteLine(advices[adviceIndex]);
    }
}