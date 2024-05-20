package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class sumMultiplesTests {

    @Test(timeout = 5000)
    public void testSolutionLimit10() {
        assertEquals(23, Main.sumMultiples(10));
    }

    @Test(timeout = 5000)
    public void testSolutionLimit3() {
        assertEquals(0, Main.sumMultiples(3));
    }

    @Test(timeout = 5000)
    public void testSolutionLimit1() {
        assertEquals(0, Main.sumMultiples(1));
    }

    @Test(timeout = 5000)
    public void testSolutionLimit0() {
        assertEquals(0, Main.sumMultiples(0));
    }

    @Test(timeout = 5000)
    public void testSolutionLimit20() {
        assertEquals(78, Main.sumMultiples(20));
    }

    @Test(timeout = 5000)
    public void testSolutionLimit1000() {
        assertEquals(233168, Main.sumMultiples(1000));
    }
}
