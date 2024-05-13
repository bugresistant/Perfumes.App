namespace Perfumes.App;

internal abstract class Odorous_Liquids
{
    // Probably that's a bad idea, maybe I should've been replaced all this shit and use instead just regular fields
    internal int AlcoholContentPCT
    {
        get => AlcoholContentPCT;
        set => AlcoholContentPCT = value;
    }

    internal int EssentialOilsContentPCT
    {
        get => EssentialOilsContentPCT;
        set => EssentialOilsContentPCT = value;
    }

    internal int PersistenceTimeInHours
    {
        get => PersistenceTimeInHours;
        set => EssentialOilsContentPCT = value;
        // Value should'nt been bigger than 12
    }
    // TODO: recommended price
}