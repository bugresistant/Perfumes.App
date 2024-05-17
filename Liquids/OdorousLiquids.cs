namespace Perfumes.App.Liquids;

internal abstract class OdorousLiquids
{
    internal LiquidType specificLiquidType; // add here = LiquidType.Argument

    internal string Name
    {
        get => Name;
        set
        {
            Name = value.Length > 24 ? value[..24] : value;
        }
    }

    internal string Description
    {
        get => Description;
        set
        {
            Description = value.Length > 200 ? value[..200] : value;
        }
    }
    internal uint AlcoholPCT
    {
        get => AlcoholPCT;
        set
        {
            //Probably it could be replaced by try/catch block, but it works fine 
            const uint DefaultAlcoholPCT = 60, MaxPCT = 95;
            if (value > MaxPCT)
            {
                Console.WriteLine($"Error, you can't specify value greater than {MaxPCT:P} (unless you want to produce moonshine) " +
                                  $"setting value by default for perfume ({DefaultAlcoholPCT:P})");
                AlcoholPCT = DefaultAlcoholPCT;
            }
            else
            {
                AlcoholPCT = value;
            }
        } 
    }

    internal uint EssentialOilsContentPCT
    {
        get => EssentialOilsContentPCT;
        set
        {
            const uint DefaultEssentialOilsContentPCT = 22, MaxContentValue = 30;
            if (value > MaxContentValue)
            {
                string specificLiquidTypeAsString = specificLiquidType.ToString();
                Console.WriteLine($"Error, you can't specify value greater than {MaxContentValue:P} (unless you want to make people around " +
                                  $"you to suffocate) setting value by default for {specificLiquidTypeAsString:P} ({DefaultEssentialOilsContentPCT})");
                EssentialOilsContentPCT = DefaultEssentialOilsContentPCT;
            }
            else
            {
                EssentialOilsContentPCT = value;
            }
        } 
    }
    
    internal uint PersistenceTimeInHours
    {
        
        get => PersistenceTimeInHours;
        // Secret formula for counting how persistant scent will be that every single perfume brand hides from you
        set
        {
            uint result = (EssentialOilsContentPCT / 10) + (AlcoholPCT / 100 * 2);
            PersistenceTimeInHours = result;
        }

    }
    // TODO: recommended price

    internal virtual string NumberOfAppliesToSkin
    {
        get => NumberOfAppliesToSkin;
        set
        {
            uint numberOfSkinAppliesInt = EssentialOilsContentPCT * 10 + AlcoholPCT * 3;
            NumberOfAppliesToSkin = $"Around {numberOfSkinAppliesInt}";
        }
    }
    internal decimal Price
    {
        get => Price;
        set
        {
            if (value < 1)
            {
                Console.WriteLine($"The price can't be lower than 1, setting the default price {1:C} for your product");
                Price = 1m;
            }
            else
            {
                Price = value;
            }
        }
    }
}