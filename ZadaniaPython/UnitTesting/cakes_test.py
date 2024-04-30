import unittest

from Zadania.main import cakes

class TestCakes(unittest.TestCase):

    def test_can_bake_two_cakes(self):
        # Arrange
        recipe = {
            "mąka": 500,
            "cukier": 200,
            "jajka": 1
        }
        available_ingredients = {
            "mąka": 1200,
            "cukier": 1200,
            "jajka": 5,
            "mleko": 200
        }
        expected = 2

        # Act
        result = cakes(recipe, available_ingredients)

        # Assert
        self.assertEqual(expected, result)

    def test_cannot_bake_any_cakes(self):
        # Arrange
        recipe = {
            "jabłka": 3,
            "mąka": 300,
            "cukier": 150,
            "mleko": 100,
            "olej": 100
        }
        available_ingredients = {
            "cukier": 500,
            "mąka": 2000,
            "mleko": 2000
        }
        expected = 0

        # Act
        result = cakes(recipe, available_ingredients)

        # Assert
        self.assertEqual(expected, result)

    def test_no_recipe_ingredient_available(self):
        # Arrange
        recipe = {
            "mąka": 500,
            "mleko": 100
        }
        available_ingredients = {}
        expected = 0

        # Act
        result = cakes(recipe, available_ingredients)

        # Assert
        self.assertEqual(expected, result)

    def test_some_recipe_ingredient_available(self):
        # Arrange
        recipe = {
            "mąka": 500,
            "mleko": 100
        }
        available_ingredients = {
            "mleko": 100
        }
        expected = 0

        # Act
        result = cakes(recipe, available_ingredients)

        # Assert
        self.assertEqual(expected, result)

    def test_exact_amounts(self):
        # Arrange
        recipe = {
            "mąka": 500,
            "cukier": 200,
            "jajka": 1
        }
        available_ingredients = {
            "mąka": 500,
            "cukier": 200,
            "jajka": 1
        }
        expected = 1

        # Act
        result = cakes(recipe, available_ingredients)

        # Assert
        self.assertEqual(expected, result)
