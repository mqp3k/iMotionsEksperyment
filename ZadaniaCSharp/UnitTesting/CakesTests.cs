namespace UnitTesting;

public class CakesTests
{
    [Fact]
    public void Cakes_CanBakeTwoCakes()
    {
        // Arrange
        var recipe = new Dictionary<string, int>
        {
            ["mąka"] = 500,
            ["cukier"] = 200,
            ["jajka"] = 1
        };
        var availableIngredients = new Dictionary<string, int>
        {
            ["mąka"] = 1200,
            ["cukier"] = 1200,
            ["jajka"] = 5,
            ["mleko"] = 200
        };
        int expected = 2;

        // Act
        int result = Program.Cakes(recipe, availableIngredients);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Cakes_CannotBakeAnyCakes()
    {
        // Arrange
        var recipe = new Dictionary<string, int>
        {
            ["jabłka"] = 3,
            ["mąka"] = 300,
            ["cukier"] = 150,
            ["mleko"] = 100,
            ["olej"] = 100
        };
        var availableIngredients = new Dictionary<string, int>
        {
            ["cukier"] = 500,
            ["mąka"] = 2000,
            ["mleko"] = 2000
        };
        int expected = 0;

        // Act
        int result = Program.Cakes(recipe, availableIngredients);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Cakes_NoRecipeIngredientAvailable()
    {
        // Arrange
        var recipe = new Dictionary<string, int>
        {
            ["mąka"] = 500,
            ["mleko"] = 100
        };
        var availableIngredients = new Dictionary<string, int> { };
        int expected = 0;

        // Act
        int result = Program.Cakes(recipe, availableIngredients);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Cakes_SomeRecipeIngredientAvailable()
    {
        // Arrange
        var recipe = new Dictionary<string, int>
        {
            ["mąka"] = 500,
            ["mleko"] = 100
        };
        var availableIngredients = new Dictionary<string, int>
        {
            ["mleko"] = 100
        };
        int expected = 0;

        // Act
        int result = Program.Cakes(recipe, availableIngredients);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Cakes_ExactAmounts()
    {
        // Arrange
        var recipe = new Dictionary<string, int>
        {
            ["mąka"] = 500,
            ["cukier"] = 200,
            ["jajka"] = 1
        };
        var availableIngredients = new Dictionary<string, int>
        {
            ["mąka"] = 500,
            ["cukier"] = 200,
            ["jajka"] = 1
        };
        int expected = 1;

        // Act
        int result = Program.Cakes(recipe, availableIngredients);

        // Assert
        Assert.Equal(expected, result);
    }
}
