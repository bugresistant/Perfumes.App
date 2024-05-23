namespace Perfumes.App.Liquids;

public class Cologne(
    string name,
    string description,
    uint alcoholPCT,
    uint maxAlcoholPCT,
    uint essentialOilsContentPCT,
    uint maxEssentialOilsContentPCT,
    decimal price)
    : OdorousLiquids(LiquidType.Cologne, name, description, alcoholPCT, maxAlcoholPCT, essentialOilsContentPCT,
        maxEssentialOilsContentPCT, price)
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Tips and tricks how to apply the cologne:\n" +
                          $"1. The Best Time:\n" +
                          $"The ideal time to apply cologne is after a shower when your skin is clean and your shores are open.\n" +
                          $"Make sure your skin is dry before applying.\n" +
                          $"2. Method of Application:\n" +
                          $"Spray cologne onto your chest or the lower jaw, depending on the strength of the cologne.\n" +
                          $"If it’s a high-concentration cologne, one spray is often enough.\n" +
                          $"For a milder one, you may apply it to more than one spot.\n" +
                          $"Just like with perfume, avoid rubbing it in to preserve the integrity of the fragrances.\n");
        Console.ResetColor();
    }
}