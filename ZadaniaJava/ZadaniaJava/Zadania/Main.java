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
        
        StringBuilder sb = new StringBuilder();


        if (names.length == 0)
        {
            sb.append("nikt tego nie lubi");
        }
        else if (names.length == 1)
        {
            sb.append(names[0]);
            sb.append(" lubi to");
        }
        else if (names.length == 2)
        {
            sb.append(names[0]);
            sb.append(" i ");
            sb.append(names[1]);
            sb.append(" lubią to");
        }
        else if (names.length == 3)
        {
            {
                sb.append(names[0]);
                sb.append(", ");
            }
            sb.append(names[1]);
            sb.append(" i ");
            sb.append(names[2]);
            sb.append(" lubią to");
        }
        else {
            sb.append(names[0]);
            sb.append(", ");
            sb.append(names[1]);
            sb.append(" i ");
            sb.append(names.length - 2);
            sb.append(" inne osoby lubią to"); 
        }
        return sb.toString();
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
        int offset = 0;
        int counter = 0;
        while (baseString.indexOf(substring, offset) != -1)
        {
        offset = baseString.indexOf(substring, offset) + 1;
            ++counter;
        }
        return counter;
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
        for (int i = 1; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
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
        int counter = 0;

        

        throw new RuntimeException();
    }
}
