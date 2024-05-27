using Perfumes.App.Liquids;

namespace UnitTestsProject;

public class PerfumeTests
{
    [Fact]
    public void DisplayInfo_DisplaysCorrectInformation()
    {
        // Arrange
        Perfume samplePerfume = new(
            "Sample Perfume",
            "Sample Description",
            10,
            20,
            30,
            40,
            50
        );

        // Act
        StringWriter sw = new();
        Console.SetOut(sw);
        samplePerfume.DisplayInfo();
        
        //it captures the output
        string output = sw.ToString();
        
        //restoring the original output
        Console.SetOut(Console.Out);


        // Assert
        Assert.Contains("Tips and tricks how to apply the perfume:", output);
        Assert.Contains("1. Select the Right Points:", output);
        Assert.Contains("Choose pulse points like the insides of your wrists, the base of your throat, behind ear lobes, and the insides of your elbows.", output);
        Assert.Contains("2. Apply Sparingly:", output);
        Assert.Contains("Spray or dab your perfume onto one or two of the selected pulse points.", output);
        Assert.Contains("Don’t rub the wrists together as this can crush the fragrance.", output);
        Assert.Contains("A light spritz is enough – remember, perfume should be discovered, not announced.", output);
    }
    
    [Fact]
    public void CalculateNumberOfAppliesToSkin_ReturnsValueInCorrectRange()
    {
        // Arrange 
        Perfume samplePerfume = new(
            "Sample Perfume",
            "Sample Description",
            10,
            20,
            30,
            40,
            50
        );
        // Act
        
        uint numberOfAppliesToSkin = samplePerfume.CalculateNumberOfAppliesToSkin();
        
        // Assert
        Assert.InRange<uint>(numberOfAppliesToSkin, 0, 2400);
    }
}