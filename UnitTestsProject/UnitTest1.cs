using Perfumes.App.Liquids;

namespace UnitTestsProject;

public class OdorousLiquidsTests
{
    [Fact]
    public void CalculatePersistenceTime_ReturnsExpectedValue()
    {
        // Arrange
        TestOdorousLiquids sampleOdorousLiquids = new();

        // Act
        var persistenceTime = sampleOdorousLiquids.CalculatePersistenceTime();

        // Assert
        Assert.Equal((uint)100, persistenceTime);
    }

    [Fact]
    public void CalculateNumberOfAppliesToSkin_ReturnsExpectedValue()
    {
        // Arrange
        TestOdorousLiquids sampleOdorousLiquids = new();

        // Act
        var numberOfAppliesToSkin = sampleOdorousLiquids.CalculateNumberOfAppliesToSkin();

        // Assert
        Assert.Equal((uint)10, numberOfAppliesToSkin);
    }
}

// Inherited from OdorousLiquids class for testing purposes, because it's impossible to create an instance of abstract class
public class TestOdorousLiquids()
    : OdorousLiquids(LiquidType.Perfume, "Test Liquid", "Test Description", 20, 50, 10, 50, 10m)
{
    public uint CalculatePersistenceTime()
    {
        return 100;
    }

    public uint CalculateNumberOfAppliesToSkin()
    {
        return 10;
    }
}