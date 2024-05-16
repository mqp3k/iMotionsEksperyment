import unittest
from wrapt_timeout_decorator import *
from Zadania.main import countSubstrings

class TestStringMethods(unittest.TestCase):

    @timeout(5)
    def test_count_substrings_ababababab(self):
        self.assertEqual(4, countSubstrings("ababababab", "aba"))

    @timeout(5)
    def test_count_substrings_banana(self):
        self.assertEqual(2, countSubstrings("banana", "na"))

    @timeout(5)
    def test_count_substrings_hello(self):
        self.assertEqual(0, countSubstrings("hello", "world"))

if __name__ == '__main__':
    unittest.main()
    