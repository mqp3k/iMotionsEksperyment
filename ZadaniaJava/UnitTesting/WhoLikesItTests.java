package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class WhoLikesItTests {

    @Test
    public void testEmptyArray() {
        String[] people = {};
        assertEquals("no one likes this", Main.whoLikesIt(people));
    }

    @Test
    public void testOnePerson() {
        String[] people = { "Peter" };
        assertEquals("Peter likes this", Main.whoLikesIt(people));
    }

    @Test
    public void testTwoPeople() {
        String[] people = { "Jacob", "Alex" };
        assertEquals("Jacob and Alex like this", Main.whoLikesIt(people));
    }

    @Test
    public void testThreePeople() {
        String[] people = { "Max", "John", "Mark" };
        assertEquals("Max, John and Mark like this", Main.whoLikesIt(people));
    }

    @Test
    public void testMoreThanThreePeople() {
        String[] people = { "Alex", "Jacob", "Mark", "Max" };
        assertEquals("Alex, Jacob and 2 others like this", Main.whoLikesIt(people));
    }
}
