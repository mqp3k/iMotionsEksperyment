namespace UnitTesting;

public class SumMultiplesTests
{
    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit10()
    {
        // Arrange
        int limit = 10;
        int expectedSum = 23; // Suma wielokrotności 3 lub 5 poniżej 10

        AssertAsync.CompletesIn(5, () =>
        {
            Program.SumMultiples(limit);
        });

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit3()
    {
        // Arrange
        int limit = 3;
        int expectedSum = 0;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.SumMultiples(limit);
        });

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit1()
    {
        // Arrange
        int limit = 1;
        int expectedSum = 0;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.SumMultiples(limit);
        });

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit0()
    {
        // Arrange
        int limit = 0;
        int expectedSum = 0;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.SumMultiples(limit);
        });

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit20()
    {
        // Arrange
        int limit = 20;
        int expectedSum = 78;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.SumMultiples(limit);
        });

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void SumMultiples_ReturnsCorrectSum_ForLimit1000()
    {
        // Arrange
        int limit = 1000;
        int expectedSum = 233168;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.SumMultiples(limit);
        });

        // Act
        int resultSum = Program.SumMultiples(limit);

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }
}