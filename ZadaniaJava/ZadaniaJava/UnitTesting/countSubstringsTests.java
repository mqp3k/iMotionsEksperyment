package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class countSubstringsTests {

    @Test(timeout = 5000)
    public void testCountSubstringsAbabababab() {
        assertEquals(4, Main.countSubstrings("ababababab", "aba"));
    }

    @Test(timeout = 5000)
    public void testCountSubstringsBanana() {
        assertEquals(2, Main.countSubstrings("banana", "na"));
    }

    @Test(timeout = 5000)
    public void testCountSubstringsHello() {
        assertEquals(0, Main.countSubstrings("hello", "world"));
    }

}
