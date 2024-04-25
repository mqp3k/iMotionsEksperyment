namespace UnitTesting;

public class WhoLikesItTests
{

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForNoLikes()
    {
        // Arrange
        string[] names = new string[] { };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("nikt tego nie lubi", result);
    }

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForOneLike()
    {
        // Arrange
        string[] names = new string[] { "Peter" };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("Peter lubi to", result);
    }

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForTwoLikes()
    {
        // Arrange
        string[] names = new string[] { "Jacob", "Alex" };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("Jacob i Alex lubią to", result);
    }

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForThreeLikes()
    {
        // Arrange
        string[] names = new string[] { "Max", "John", "Mark" };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("Max, John i Mark lubią to", result);
    }

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForFourLikes()
    {
        // Arrange
        string[] names = new string[] { "Alex", "Jacob", "Mark", "Max" };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("Alex, Jacob i 2 inne osoby lubią to", result);
    }
}
