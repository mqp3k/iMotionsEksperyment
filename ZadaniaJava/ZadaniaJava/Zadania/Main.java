package ZadaniaJava.Zadania;

import java.util.Map;

public class Main {

    public static void main(String[] args) {

    }

    // Zadanie programistyczne 1
    // Prawdopodobnie znasz system "polubień" z Facebooka i innych stron.Ludzie mogą
    // "polubić" posty na blogu, zdjęcia lub inne elementy.
    // Chcemy utworzyć tekst, który powinien być wyświetlany obok takiego elementu.

    // Zaimplementuj funkcję, która pobiera tablicę zawierającą imiona osób, które
    // polubiły dany element.
    // Musi ona zwracać tekst wyświetlany tak, jak pokazano w przykładach:

    // [] --> "nikt tego nie lubi"
    // [" Peter"] --> "Peter lubi to"
    // ["Jacob", "Alex"] --> "Jacob i Alex lubią to"
    // ["Max", "John", "Mark"] --> "Max, John i Mark lubią to"
    // ["Alex", "Jacob", "Mark", "Max"] --> "Alex, Jacob i 2 inne osoby lubią to".
    // Uwaga: W przypadku 4 lub więcej imion liczba w "i 2 inne…" po prostu wzrasta.

    public static String whoLikesIt(String[] names) {
        if (names.length == 0) {
            return "nikt tego nie lubi";
        } else if (names.length == 1) {
            return names[0] + " lubi to";
        } else if (names.length == 2) {
            return names[0] + " i " + names[1] + " lubią to";
        } else if (names.length == 3) {
            return names[0] + ", " + names[1] + " i " + names[2] + " lubią to";
        } else if (names.length > 3) {
            return names[0] + ", " + names[1] + " i " + String.valueOf(names.length - 2) + " inne osoby lubią to";
        }
        throw new RuntimeException();
    }

    // Zadanie programistyczne 2
    // Metoda CountSubstrings przyjmuje dwa łańcuchy znaków: 'baseString' i
    // 'substring',
    // a następnie zlicza wystąpienia podciągu 'substring' w łańcuchu 'baseString'.
    // Parametry:
    // - baseString: główny łańcuch znaków, w którym ma zostać przeszukany podciąg
    // - substring: podciąg, który ma zostać znaleziony w łańcuchu 'string'
    // Zwraca:
    // - Liczba wystąpień podciągu 'substring' w łańcuchu 'baseString'

    // Przykład użycia:
    // >>> countSubstrings("ababababab", "aba")
    // 4
    // >>> countSubstrings("banana", "na")
    // 2
    // >>> countSubstrings("hello", "world")
    // 0

    public static int countSubstrings(String baseString, String substring) {
        
        throw new RuntimeException();
    }

    // Zadanie programistyczne 3
    // Jeśli wypiszemy wszystkie liczby naturalne poniżej 10, które są
    // wielokrotnościami 3 lub 5, otrzymamy 3, 5, 6 i 9. Suma tych wielokrotności
    // wynosi 23.
    // Dokończ rozwiązanie tak, aby zwracało sumę wszystkich wielokrotności 3 lub 5
    // poniżej przekazanej liczby.
    // Uwaga: jeśli liczba jest wielokrotnością 3 i 5, policz ją tylko raz.

    public static int sumMultiples(int limit) {
        int sum = 0;
        int part1 = 0;
        int part2 = 0;
        for(int i = 1; part1 < limit; i++) {
            
            part1 = part1 + i*3;
            System.out.println(part1);
        }
        for(int i=1; part2 < limit; i++) {
            if (!((part2 + i*5) % 3 == 0)) {
                
                part2 = part2 + i*5;
                System.out.println(part2);
            }
        }
        sum=part1+part2;
        if (sum != 0)
            return sum;
        throw new RuntimeException();
    }

    // Zadanie programistyczne 4
    // Pete lubi piec ciasta. Ma kilka przepisów i składników. Niestety nie jest
    // dobry z matematyki.
    // Czy możesz mu pomóc dowiedzieć się, ile ciast mógłby upiec, biorąc pod uwagę
    // jego przepisy?

    // Napisz metodę cakes(), która przyjmuje przepis (Map<String, Int>) i
    // dostępne składniki (również Map)
    // i zwraca maksymalną liczbę ciast, które Pete może upiec (liczba całkowita).
    // Dla uproszczenia nie ma jednostek dla ilości (np. 1 kilogram mąki lub 200g
    // cukru to po prostu 1 lub 200).
    // Składniki, które nie występują w obiektach, mogą być traktowane jako 0.

    // Przykłady:
    // >>> cakes(new HashMap<String, Integer>(){{put("mąka", 500); put("cukier", 200); put("jajka", 1);}},
    //           new HashMap<String, Integer>(){{put("mąka", 1200); put("cukier", 1200); put("jajka", 5); put("mleko", 200);}});
    // # musi zwrócić 2

    // >>> cakes(new HashMap<String, Integer>(){{put("jabłka", 3); put("mąka", 300); put("cukier", 150); put("mleko", 100); put("olej", 100);}},
    //           new HashMap<String, Integer>(){{put("cukier", 500); put("mąka", 2000); put("mleko", 2000);}});
    // # musi zwrócić 0

    public static int cakes(Map<String, Integer> recipe, Map<String, Integer> availableIngredients) {
        throw new RuntimeException();
    }
}
