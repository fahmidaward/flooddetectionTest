using Xunit;

public class flooddetectionTest
{
    [Theory]
    [InlineData(9.9, "Green")]
    [InlineData(10.0, "Amber")]
    [InlineData(14.9, "Amber")]
    [InlineData(15.0, "Red")]
    [InlineData(20.0, "Red")]
    [InlineData(-1, "Green")]  // Testing edge case below the specified range
    public void GetStatus_ReturnsCorrectStatusBasedOnRainfall(double rainfall, string expected)
    {
        // Act
        string result = GetStatus(rainfall);

        // Assert
        Assert.Equal(expected, result);
    }

    private static string GetStatus(double averageRainfall)
    {
        if (averageRainfall < 10.0)
            return "Green";
        else if (averageRainfall < 15.0 && averageRainfall >= 10)
            return "Amber";
        else if (averageRainfall >= 15.0)
            return "Red";
        else return "Green";
    }
}

