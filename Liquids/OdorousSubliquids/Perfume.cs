﻿namespace Perfumes.App.Liquids;

internal class Perfume(
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
}