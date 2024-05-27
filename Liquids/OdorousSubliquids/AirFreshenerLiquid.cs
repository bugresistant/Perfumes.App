using Perfumes.App.Utility;

namespace Perfumes.App.Liquids;

public class AirFreshenerLiquid(
    string name,
    string description,
    uint alcoholPCT, uint maxAlcoholPCT,
    uint essentialOilsContentPCT, uint maxEssentialOilContentPCT,
    decimal price)
    : OdorousLiquids(LiquidType.AirFreshenerLiquid, name, description, alcoholPCT, maxAlcoholPCT, essentialOilsContentPCT, maxEssentialOilContentPCT, price)
{
    protected override uint NumberOfAppliesToSkin 
    {
        get
        {
            throw new ToxicSubstanceException(
                "ERROR: Air freshener liquids are toxic and can not be applied to the skin, be careful!");
            Console.ResetColor();
        } 
    }

    public override uint CalculateNumberOfAppliesToSkin()
    {
        return 0;
    }
}