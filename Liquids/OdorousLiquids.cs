namespace Perfumes.App.Liquids;

internal abstract class OdorousLiquids
{ 
    protected string name, description, numberOfAppliesToSkin;
    protected uint alcoholPCT, essentialOilsContentPCT, persistenceTimeInHours;
    protected decimal price;
    
    
    private LiquidType SpecificLiquidType { get; init; }
    
    public string Name
    {
        get => name;
        init => name = value.Length > 24 ? value[..24] : value;
    }

     string Description
    {
        get => description;
        init => description = value.Length > 200 ? value[..200] : value;
    }
    public uint AlcoholPCT // Alcohol by volume
    {
        get => alcoholPCT;
        init
        {
            //Probably it could be replaced by try/catch block, but it works fine 
            const uint DefaultAlcoholPCT = 60, MaxPCT = 95;
            if (value > MaxPCT)
            {
                Console.WriteLine($"Error, you can't specify value greater than {MaxPCT:P} (unless you want to produce moonshine) " +
                                  $"setting value by default for {SpecificLiquidType.ToString()} ({DefaultAlcoholPCT:P})");
                alcoholPCT = DefaultAlcoholPCT;
            }
            else
            {
                alcoholPCT = value;
            }
        } 
    }

    public uint EssentialOilsContentPCT
    {
        get => essentialOilsContentPCT;
        init
        {
            const uint DefaultEssentialOilsContentPCT = 22, MaxContentValue = 30;
            if (value > MaxContentValue)
            {
                Console.WriteLine($"Error, you can't specify value greater than {MaxContentValue:P} (unless you want to make people around " +
                                  $"you to suffocate) setting value by default for {SpecificLiquidType.ToString():P} ({DefaultEssentialOilsContentPCT})");
                essentialOilsContentPCT = DefaultEssentialOilsContentPCT;
            }
            else
            {
                essentialOilsContentPCT = value;
            }
        } 
    }
    
    public uint PersistenceTimeInHours
    {
        
        get => persistenceTimeInHours;
        // Secret formula for counting how persistant scent will be that every single perfume brand hides from you
        protected init => persistenceTimeInHours = (EssentialOilsContentPCT / 10) + (AlcoholPCT / 100 * 2);
    }
    // TODO: recommended price
    public decimal Price
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
    
    public virtual string NumberOfAppliesToSkin
    {
        get => $"around {numberOfAppliesToSkin} times";
        protected init
        {
            uint numberOfSkinAppliesInt = EssentialOilsContentPCT * 10 + AlcoholPCT * 3;
            numberOfAppliesToSkin = Convert.ToString(numberOfAppliesToSkin);
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Type of the liquid: {SpecificLiquidType.ToString()}" +
                           $"\nName of the liquid: {Name}" +
                           $"\nDescription of the liquid: {Description}" +
                           $"\nAlcohol by volume: {AlcoholPCT:P}" +
                           $"\nEssential oils content: {EssentialOilsContentPCT:P}" +
                           $"\nAverage effect duration in hours: {PersistenceTimeInHours}" +
                           $"\nCurrent price: {Price:C}" +
                           $"\nMaximal capacity (in uses): {NumberOfAppliesToSkin}");
    }

    public OdorousLiquids(LiquidType liquidType, string name, string description, uint alcoholPCT, uint essentialOilsContentPCT, decimal price)
    {
        SpecificLiquidType = liquidType; // just a regular enum
        Name = name; Description = description; // string
        AlcoholPCT = alcoholPCT; EssentialOilsContentPCT = essentialOilsContentPCT;// uint
        Price = price; // decimal
    }
}