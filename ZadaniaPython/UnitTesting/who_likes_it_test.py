import unittest
from wrapt_timeout_decorator import *
from Zadania.main import whoLikesIt

class WhoLikesItTests (unittest.TestCase):

    @timeout(5)
    def test_empty_array(self):
        people = []
        self.assertEqual("nikt tego nie lubi", whoLikesIt(people))

    @timeout(5)
    def test_one_person(self):
        people = ['Peter']
        self.assertEqual("Peter lubi to", whoLikesIt(people))

    @timeout(5)
    def test_two_people(self):
        people = ["Jacob", "Alex"]
        self.assertEqual("Jacob i Alex lubią to", whoLikesIt(people))

    @timeout(5)
    def test_three_people(self):
        people = ["Max", "John", "Mark"]
        self.assertEqual("Max, John i Mark lubią to", whoLikesIt(people))

    @timeout(5)
    def test_more_than_three_people(self):
        people = ["Alex", "Jacob", "Mark", "Max"]
        self.assertEqual("Alex, Jacob i 2 inne osoby lubią to", whoLikesIt(people))

if __name__ == '__main__':
    unittest.main()