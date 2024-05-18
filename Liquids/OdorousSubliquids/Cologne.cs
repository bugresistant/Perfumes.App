namespace Perfumes.App.Liquids;

internal class Cologne(
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
}