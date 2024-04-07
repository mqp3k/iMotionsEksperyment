namespace CountSubstrings_UnitTesting;

public class CountSubstringsTests
{
    [Fact]
    public void CountSubstrings_ReturnsCorrectCount_ForValidSubstring()
    {
        // Arrange
        string mainString = "ababababab";
        string subString = "aba";
        int expectedCount = 4;

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountSubstrings_ReturnsCorrectCount_ForSubstringAtBeginning()
    {
        // Arrange
        string mainString = "banana";
        string subString = "ba";
        int expectedCount = 1;

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

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountSubstrings_ReturnsZero_ForEmptyMainString()
    {
        // Arrange
        string mainString = "";
        string subString = "aba";
        int expectedCount = 0;

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountSubstrings_ReturnsZero_ForEmptySubstring()
    {
        // Arrange
        string mainString = "ababababab";
        string subString = "";
        int expectedCount = 0;

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountSubstrings_ReturnsOne_ForIdenticalMainAndSubstring()
    {
        // Arrange
        string mainString = "hello";
        string subString = "hello";
        int expectedCount = 1;

        // Act
        int result = Program.CountSubstrings(mainString, subString);

        // Assert
        Assert.Equal(expectedCount, result);
    }
}
