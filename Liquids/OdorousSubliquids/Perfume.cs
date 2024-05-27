namespace Perfumes.App.Liquids;

public class Perfume(
    string name,
    string description,
    uint alcoholPCT,
    uint maxAlcoholPCT,
    uint essentialOilsContentPCT,
    uint maxEssentialOilsContentPCT,
    decimal price)
    : OdorousLiquids(LiquidType.Perfume, name, description, alcoholPCT, maxAlcoholPCT, essentialOilsContentPCT,
        maxEssentialOilsContentPCT, price)
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Tips and tricks how to apply the perfume:\n" +
                          $"1. Select the Right Points:\n" +
                          $"Choose pulse points like the insides of your wrists, the base of your throat, behind ear lobes, and the insides of your elbows.\n" +
                          $"These areas are where the veins are closest to the skin, so they tend to be warmer and help in emanating the perfume's fragrance throughout the day.\n" +
                          $"2. Apply Sparingly:\n" +
                          $"Spray or dab your perfume onto one or two of the selected pulse points.\n" +
                          $"Don’t rub the wrists together as this can crush the fragrance.\n" +
                          $"A light spritz is enough – remember, perfume should be discovered, not announced.\n");
        Console.ResetColor();
    }

    public override uint CalculateNumberOfAppliesToSkin()
    {
        uint numberOfAppliesToSkin = (uint)new Random().Next(2400);
        return numberOfAppliesToSkin;
    }
}