package ZadaniaJava.Zadania;

import java.util.Map;
import java.util.Map.Entry;

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
        switch (names.length) {
            case 0:
                return "nikt tego nie lubi";
            case 1:
                return names[0] + " lubi to";
            case 2:
                return names[0] + " i " + names[1] + " lubią to";
            case 3:
                return names[0] + ", " + names[1] + " i " + names[2] + " lubią to";
            default:
                StringBuilder sb = new StringBuilder();
                sb.append(names[0]).append(", ");
                sb.append(names[1]).append(" i ");
                sb.append(names.length - 2);
                sb.append(" inne osoby lubią to");
                return sb.toString();
        }
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
        int ch = 0;
        int n = 0;
        for (int i = 0; i < baseString.length(); i++) {
            if (ch == substring.length() - 1) {
                ch = 0;
                n++;
            }
            if (baseString.charAt(i) == substring.charAt(ch)) {
                ch++;
            }
            else {
                ch = 0;
            }
        }
        return n;
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
        for (int i = 0; i < limit; i++) {
            if (i % 3 == 0 || i % 5 == 0)
                sum += i;
        }
        return sum;
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
        for (Entry<String, Integer> entry : recipe.entrySet()) {
            System.out.println(entry.getKey());
        }
        return 0;
    }
}
