using Perfumes.App.Utility;

namespace Perfumes.App.Liquids;

internal class AirFreshenerLiquid(
    string name,
    string description,
    uint alcoholPCT,
    uint essentialOilsContentPCT,
    decimal price)
    : OdorousLiquids(LiquidType.AirFreshenerLiquid, name, description, alcoholPCT, essentialOilsContentPCT, price)
{
    public override string NumberOfAppliesToSkin 
    {
        get
        {
            throw new ToxicSubstanceException(
                "ERROR: Air freshener liquids are toxic and can not be applied to the skin, be careful!");
            Console.ResetColor();
        } 
    }
}