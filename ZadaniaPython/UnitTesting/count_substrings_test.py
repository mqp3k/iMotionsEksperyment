import unittest
from Zadania.main import countSubstrings

class TestStringMethods(unittest.TestCase):

    def test_count_substrings_ababababab(self):
        self.assertEqual(4, countSubstrings("ababababab", "aba"))

    def test_count_substrings_banana(self):
        self.assertEqual(2, countSubstrings("banana", "na"))

    def test_count_substrings_hello(self):
        self.assertEqual(0, countSubstrings("hello", "world"))

if __name__ == '__main__':
    unittest.main()
    