namespace UnitTesting;

public class CountSubstringsTests
{
    [Fact]
    public void CountSubstrings_ReturnsCorrectCount_ForValidSubstring()
    {
        // Arrange
        string mainString = "ababababab";
        string subString = "aba";
        int expectedCount = 4;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.CountSubstrings(mainString, subString);
        });

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountSubstrings_ReturnsCorrectCount_ForSubstringAtEnd()
    {
        // Arrange
        string mainString = "banana";
        string subString = "na";
        int expectedCount = 2;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.CountSubstrings(mainString, subString);
        });

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountSubstrings_ReturnsZero_ForInvalidSubstring()
    {
        // Arrange
        string mainString = "hello";
        string subString = "world";
        int expectedCount = 0;

        AssertAsync.CompletesIn(5, () =>
        {
            Program.CountSubstrings(mainString, subString);
        });

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }
}
