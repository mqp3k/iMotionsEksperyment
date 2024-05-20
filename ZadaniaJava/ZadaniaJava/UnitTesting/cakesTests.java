package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import java.util.Dictionary;
import java.util.HashMap;
import java.util.Map;

import ZadaniaJava.Zadania.Main;

public class cakesTests {

    @Test(timeout = 5000)
    public void testCakesCanBakeTwoCakes() {
        // Arrange
        Map<String, Integer> recipe = new HashMap<>();
        recipe.put("mąka", 500);
        recipe.put("cukier", 200);
        recipe.put("jajka", 1);

        Map<String, Integer> availableIngredients = new HashMap<>();
        availableIngredients.put("mąka", 1200);
        availableIngredients.put("cukier", 1200);
        availableIngredients.put("jajka", 5);
        availableIngredients.put("mleko", 200);

        int expected = 2;

        // Act
        int result = Main.cakes(recipe, availableIngredients);

        // Assert
        assertEquals(expected, result);
    }

    @Test(timeout = 5000)
    public void testCakesCannotBakeAnyCakes() {
        // Arrange
        Map<String, Integer> recipe = new HashMap<>();
        recipe.put("jabłka", 3);
        recipe.put("mąka", 300);
        recipe.put("cukier", 150);
        recipe.put("mleko", 100);
        recipe.put("olej", 100);

        Map<String, Integer> availableIngredients = new HashMap<>();
        availableIngredients.put("cukier", 500);
        availableIngredients.put("mąka", 2000);
        availableIngredients.put("mleko", 2000);

        int expected = 0;

        // Act
        int result = Main.cakes(recipe, availableIngredients);

        // Assert
        assertEquals(expected, result);
    }

    @Test(timeout = 5000)
    public void testCakesNoRecipeIngredientAvailable() {
        // Arrange
        Map<String, Integer> recipe = new HashMap<>();
        recipe.put("mąka", 500);
        recipe.put("mleko", 100);

        Map<String, Integer> availableIngredients = new HashMap<>();

        int expected = 0;

        // Act
        int result = Main.cakes(recipe, availableIngredients);

        // Assert
        assertEquals(expected, result);
    }

    @Test(timeout = 5000)
    public void testCakesSomeRecipeIngredientAvailable() {
        // Arrange
        Map<String, Integer> recipe = new HashMap<>();
        recipe.put("mąka", 500);
        recipe.put("mleko", 100);

        Map<String, Integer> availableIngredients = new HashMap<>();
        availableIngredients.put("mleko", 100);

        int expected = 0;

        // Act
        int result = Main.cakes(recipe, availableIngredients);

        // Assert
        assertEquals(expected, result);
    }

    @Test(timeout = 5000)
    public void testCakesExactAmounts() {
        // Arrange
        Map<String, Integer> recipe = new HashMap<>();
        recipe.put("mąka", 500);
        recipe.put("cukier", 200);
        recipe.put("jajka", 1);

        Map<String, Integer> availableIngredients = new HashMap<>();
        availableIngredients.put("mąka", 500);
        availableIngredients.put("cukier", 200);
        availableIngredients.put("jajka", 1);

        int expected = 1;

        // Act
        int result = Main.cakes(recipe, availableIngredients);

        // Assert
        assertEquals(expected, result);
    }
}
