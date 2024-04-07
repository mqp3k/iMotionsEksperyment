package ZadaniaJava.UnitTesting;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import ZadaniaJava.Zadania.Main;

public class sumMultiplesTests {
    @Test
    public void testSolutionExample1() {
        assertEquals(23, Main.sumMultiples(10));
    }

    @Test
    public void testSolutionExample2() {
        assertEquals(0, Main.sumMultiples(3));
    }

    @Test
    public void testSolutionExample3() {
        assertEquals(0, Main.sumMultiples(1));
    }

    @Test
    public void testSolutionExample4() {
        assertEquals(0, Main.sumMultiples(0));
    }

    @Test
    public void testSolutionExample5() {
        assertEquals(78, Main.sumMultiples(20));
    }

    @Test
    public void testSolutionExample6() {
        assertEquals(233168, Main.sumMultiples(1000));
    }
}
