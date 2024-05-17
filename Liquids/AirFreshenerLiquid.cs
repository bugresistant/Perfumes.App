using Perfumes.App.Utility;

namespace Perfumes.App.Liquids;

internal class AirFreshenerLiquid: OdorousLiquids
{
    LiquidType specificLiquidType = LiquidType.AirFreshenerLiquid;

    internal override string NumberOfAppliesToSkin
    {
        get
        {
            throw new ToxicSubstanceException(
                "ERROR: Air freshener liquids are toxic and cannot be applied to the skin, be careful!");
            Console.ResetColor();
        } 
    }
}