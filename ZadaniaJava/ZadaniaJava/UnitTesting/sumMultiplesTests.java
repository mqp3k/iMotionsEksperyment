package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class sumMultiplesTests {
    @Test
    public void testSolutionLimit10() {
        assertEquals(23, Main.sumMultiples(10));
    }

    @Test
    public void testSolutionLimit3() {
        assertEquals(0, Main.sumMultiples(3));
    }

    @Test
    public void testSolutionLimit1() {
        assertEquals(0, Main.sumMultiples(1));
    }

    @Test
    public void testSolutionLimit0() {
        assertEquals(0, Main.sumMultiples(0));
    }

    @Test
    public void testSolutionLimit20() {
        assertEquals(78, Main.sumMultiples(20));
    }

    @Test
    public void testSolutionLimit1000() {
        assertEquals(233168, Main.sumMultiples(1000));
    }
}
