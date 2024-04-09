package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class WhoLikesItTests {

    @Test
    public void testEmptyArray() {
        String[] people = {};
        assertEquals("nikt tego nie lubi", Main.whoLikesIt(people));
    }

    @Test
    public void testOnePerson() {
        String[] people = { "Peter" };
        assertEquals("Peter lubi to", Main.whoLikesIt(people));
    }

    @Test
    public void testTwoPeople() {
        String[] people = { "Jacob", "Alex" };
        assertEquals("Jacob i Alex lubią to", Main.whoLikesIt(people));
    }

    @Test
    public void testThreePeople() {
        String[] people = { "Max", "John", "Mark" };
        assertEquals("Max, John i Mark lubią to", Main.whoLikesIt(people));
    }

    @Test
    public void testMoreThanThreePeople() {
        String[] people = { "Alex", "Jacob", "Mark", "Max" };
        assertEquals("Alex, Jacob i 2 inne osoby lubią to", Main.whoLikesIt(people));
    }
}
