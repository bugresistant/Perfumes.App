using Perfumes.App.Liquids;

namespace UnitTestsProject;

public class CologneTests
{
    [Fact]
    public void DisplayInfo_DisplaysCorrectInformation()
    {
        // Arrange
        Cologne sampleCologne = new(
            "Sample Cologne",
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
        sampleCologne.DisplayInfo();
        
        //it captures the output
        string output = sw.ToString();
        
        //restoring the original output
        Console.SetOut(Console.Out);
        

        // Assert;
        Assert.Contains("Tips and tricks how to apply the cologne:", output);
        Assert.Contains("1. The Best Time:", output);
        Assert.Contains("The ideal time to apply cologne is after a shower when your skin is clean and your shores are open.", output);
        Assert.Contains("Make sure your skin is dry before applying.", output);
        Assert.Contains("2. Method of Application:", output);
        Assert.Contains("Spray cologne onto your chest or the lower jaw, depending on the strength of the cologne.", output);
        Assert.Contains("If it’s a high-concentration cologne, one spray is often enough.", output);
        Assert.Contains("For a milder one, you may apply it to more than one spot.", output);
        Assert.Contains("Just like with perfume, avoid rubbing it in to preserve the integrity of the fragrances.", output);
    }
    
    [Fact]
    
    public void CalculateNumberOfAppliesToSkin_ReturnsExpectedValue()
    {
        // Arrange
        Cologne sampleCologne = new(
            "Sample Cologne",
            "Sample Description",
            10,
            20,
            30,
            40,
            50
        );
        
        // Act
        var numberOfAppliesToSkin = sampleCologne.CalculateNumberOfAppliesToSkin();
        
        // Assert
        Assert.Equal((uint)6000, numberOfAppliesToSkin);
    }
}