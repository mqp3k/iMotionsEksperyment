namespace WhoLikesIt_UnitTesting;

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

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForFiveLikes()
    {
        // Arrange
        string[] names = new string[] { "Alex", "Jacob", "Mark", "Max", "John" };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("Alex, Jacob i 3 inne osoby lubią to", result);
    }

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForTenLikes()
    {
        // Arrange
        string[] names = new string[] { "Alex", "Jacob", "Mark", "Max", "John", "Alice", "Mary", "Jane", "Emily", "Sarah" };

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("Alex, Jacob i 8 inne osoby lubią to", result);
    }

    [Fact]
    public void WhoLikesIt_ReturnsCorrectText_ForFiftyLikes()
    {
        // Arrange
        string[] names = Enumerable.Repeat("User", 50).ToArray();

        // Act
        string result = Program.WhoLikesIt(names);

        // Assert
        Assert.Equal("User, User i 48 inne osoby lubią to", result);
    }
}
