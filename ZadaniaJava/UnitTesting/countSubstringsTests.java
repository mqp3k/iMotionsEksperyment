package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class countSubstringsTests {

    @Test
    public void testCountSubstringsExample1() {
        assertEquals(4, Main.countSubstrings("ababababab", "aba"));
    }

    @Test
    public void testCountSubstringsExample2() {
        assertEquals(2, Main.countSubstrings("banana", "na"));
    }

    @Test
    public void testCountSubstringsExample3() {
        assertEquals(0, Main.countSubstrings("hello", "world"));
    }

}
