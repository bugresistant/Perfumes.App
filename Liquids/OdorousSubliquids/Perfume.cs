namespace Perfumes.App.Liquids;

internal class Perfume(
    string name,
    string description,
    uint alcoholPCT, uint maxAlcoholPCT,
    uint essentialOilsContentPCT, uint maxEssentialOilsContentPCT,
    decimal price)
    : OdorousLiquids(LiquidType.Perfume, name, description, alcoholPCT, maxAlcoholPCT, essentialOilsContentPCT, maxEssentialOilsContentPCT, price)
{
    //protected override uint MaxAlcoholPCT
    //{
        //get => maxAlcoholPCT;
      //  set => maxAlcoholPCT = value;
    //}

    //protected override uint MaxEssentialOilsContentPCT 
    //{ 
    //    get => maxEssentialOilContentPCT;
      //  set => maxEssentialOilContentPCT = value;
    //}
}