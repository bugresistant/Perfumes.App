namespace Perfumes.App.Liquids;

internal abstract class OdorousLiquids
{ 
    protected string name, description;
    protected uint alcoholPCT, maxAlcoholPCT,
                   essentialOilsContentPCT, maxEssentialOilContentPCT,
                   persistenceTimeInHours, numberOfAppliesToSkin;

    private decimal price;
    
    
    private LiquidType SpecificLiquidType { get; init; }

    private string Name
    {
        get => name;
        init => name = value.Length > 24 ? value[..24] : value;
    }

     string Description
    {
        get => description;
        init => description = value.Length > 200 ? value[..200] : value;
    }


    private uint DefaultAlcoholPCT { get; set; }
    protected virtual uint MaxAlcoholPCT
    {
        get => maxAlcoholPCT;
        init => maxAlcoholPCT = value > 100 ? 100 : value;
    }

    private uint AlcoholPCT // Alcohol by volume
    {
        get => alcoholPCT;
        init
        {
            //Probably it could be replaced by try/catch block, but it works fine 
            if (value > MaxAlcoholPCT)
            {
                Console.WriteLine($"Error, you can't specify value greater than {MaxAlcoholPCT}%, setting value by default for {SpecificLiquidType.ToString()}% is being triggered ({DefaultAlcoholPCT}%)");
                alcoholPCT = DefaultAlcoholPCT;
            }
            else
            {
                alcoholPCT = value;
            }
        } 
    }


    private uint DefaultEssentialOilsContentPCT { get; set; }

    private uint MaxEssentialOilsContentPCT
    {
        get => maxEssentialOilContentPCT;
        init => maxEssentialOilContentPCT = value > 100 ? 100 : value;
    }

    private uint EssentialOilsContentPCT
    {
        get => essentialOilsContentPCT;
        init
        {
            if (value > MaxEssentialOilsContentPCT)
            {
                Console.WriteLine($"Error, you can't specify value greater than {MaxEssentialOilsContentPCT}%, setting value by default for {SpecificLiquidType.ToString()}% is being triggered ({DefaultEssentialOilsContentPCT})");
                essentialOilsContentPCT = DefaultEssentialOilsContentPCT;
            }
            else
            {
                essentialOilsContentPCT = value;
            }
        } 
    }

    private uint PersistenceTimeInHours => CalculatePersistenceTime();

    // TODO: recommended price
    private decimal Price
    {
        get => price;
        init
        {
            decimal defaultPrice = 1m;
            if (value < 1)
            {
                Console.WriteLine($"The price can't be lower than 1, setting the default price {defaultPrice:C} for your product");
                price = defaultPrice;
            }
            else
            {
                price = value;
            }
        }
    }

    protected virtual uint NumberOfAppliesToSkin
    {
        get => numberOfAppliesToSkin;
        init => numberOfAppliesToSkin = CalculateNumberOfAppliesToSkin();
    }
    
    // Secret formula with a couple of magic numbers for counting how persistent scent will be that every single perfume brand hides from you
    private uint CalculatePersistenceTime()
    {
        return (MaxAlcoholPCT + AlcoholPCT) * (MaxEssentialOilsContentPCT + EssentialOilsContentPCT) / 100;
    }
    
    // Another magic formula over here
    private uint CalculateNumberOfAppliesToSkin()
    {
        
        return ((MaxAlcoholPCT * AlcoholPCT) * (MaxEssentialOilsContentPCT + EssentialOilsContentPCT)/10);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Type of the liquid: {SpecificLiquidType.ToString()}" +
                           $"\nName of the liquid: {Name}" +
                           $"\nDescription of the liquid: {Description}" +
                           $"\nAlcohol by volume: {AlcoholPCT}%" +
                           $"\nEssential oils content: {EssentialOilsContentPCT}%" +
                           $"\nAverage effect duration in hours: {PersistenceTimeInHours}" +
                           $"\nCurrent price: {Price:C}" +
                           $"\nMaximal capacity (in uses): around {NumberOfAppliesToSkin}" +
                           $"\n\n\n");
    }

    protected OdorousLiquids(LiquidType liquidType, string name, string description, uint alcoholPCT, uint maxAlcoholPCT, uint essentialOilsContentPCT, uint maxEssentialOilsContentPCT, decimal price)
    {
        SpecificLiquidType = liquidType;
        Name = name; Description = description;
        MaxAlcoholPCT = maxAlcoholPCT;
        DefaultAlcoholPCT = 30;
        AlcoholPCT = alcoholPCT;
        MaxEssentialOilsContentPCT = maxEssentialOilsContentPCT;
        DefaultEssentialOilsContentPCT = 10;
        EssentialOilsContentPCT = essentialOilsContentPCT;
        NumberOfAppliesToSkin = numberOfAppliesToSkin;
        Price = price;
    }
}