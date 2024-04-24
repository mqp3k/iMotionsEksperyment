import unittest
from Zadania.main import sumMultiples

class TestStringMethods(unittest.TestCase):

    def test_solution_limit_10(self):
        self.assertEqual(23, sumMultiples(10))

    def test_solution_limit_3(self):
        self.assertEqual(0, sumMultiples(3))

    def test_solution_limit_1(self):
        self.assertEqual(0, sumMultiples(1))

    def test_solution_limit_0(self):
        self.assertEqual(0, sumMultiples(0))

    def test_solution_limit_20(self):
        self.assertEqual(78, sumMultiples(20))

    def test_solution_limit_1000(self):
        self.assertEqual(233168, sumMultiples(1000))

if __name__ == '__main__':
    unittest.main()
