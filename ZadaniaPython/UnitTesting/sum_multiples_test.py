import unittest
from wrapt_timeout_decorator import timeout
from Zadania.main import sumMultiples

class SumMultiplesTests (unittest.TestCase):

    @timeout(5)
    def test_solution_limit_10(self):
        self.assertEqual(23, sumMultiples(10))

    @timeout(5)
    def test_solution_limit_3(self):
        self.assertEqual(0, sumMultiples(3))

    @timeout(5)
    def test_solution_limit_1(self):
        self.assertEqual(0, sumMultiples(1))

    @timeout(5)
    def test_solution_limit_0(self):
        self.assertEqual(0, sumMultiples(0))

    @timeout(5)
    def test_solution_limit_20(self):
        self.assertEqual(78, sumMultiples(20))

    @timeout(5)
    def test_solution_limit_1000(self):
        self.assertEqual(233168, sumMultiples(1000))

if __name__ == '__main__':
    unittest.main()
