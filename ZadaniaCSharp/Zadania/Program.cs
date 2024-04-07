namespace Zadania;

public class Program
{
    // Zadanie programistyczne 1
    // Prawdopodobnie znasz system "polubień" z Facebooka i innych stron.Ludzie mogą "polubić" posty na blogu, zdjęcia lub inne elementy.
    // Chcemy utworzyć tekst, który powinien być wyświetlany obok takiego elementu.

    //Zaimplementuj funkcję, która pobiera tablicę zawierającą imiona osób, które polubiły dany element. 
    // Musi ona zwracać tekst wyświetlany tak, jak pokazano w przykładach:

    //[] --> "nikt tego nie lubi"
    // [" Peter"] --> "Peter lubi to"
    // ["Jacob", "Alex"] --> "Jacob i Alex lubią to"
    // ["Max", "John", "Mark"] --> "Max, John i Mark lubią to"
    // ["Alex", "Jacob", "Mark", "Max"] --> "Alex, Jacob i 2 inne osoby lubią to".
    // Uwaga: W przypadku 4 lub więcej imion liczba w "i 2 inne…" po prostu wzrasta.

    public static string WhoLikesIt(string[] names)
    {
        int length = names.Length;

        switch (length)
        {
            case 0:
                return "nikt tego nie lubi";
            case 1:
                return $"{names[0]} lubi to";
            case 2:
                return $"{names[0]} i {names[1]} lubią to";
            case 3:
                return $"{names[0]}, {names[1]} i {names[2]} lubią to";
            default:
                return $"{names[0]}, {names[1]} i {length - 2} inne osoby lubią to";
        }
    }


    // Zadanie programistyczne 2
    // Metoda CountSubstrings przyjmuje dwa łańcuchy znaków: 'baseString' i 'substring',
    // a następnie zlicza wystąpienia podciągu 'substring' w łańcuchu 'baseString'.
    // Parametry:
    // - baseString: główny łańcuch znaków, w którym ma zostać przeszukany podciąg
    // - substring: podciąg, który ma zostać znaleziony w łańcuchu 'string'
    // Zwraca:
    // - Liczba wystąpień podciągu 'substring' w łańcuchu 'baseString'

    // Przykład użycia:
    // >>> count_substrings("ababababab", "aba")
    // 4
    // >>> count_substrings("banana", "na")
    // 2
    // >>> count_substrings("hello", "world")
    // 0

    public static int CountSubstrings(string baseString, string substring)
    {
        int count = baseString.Select((c, i) => baseString.Substring(i))
            .Count(sub => sub.StartsWith(substring));

        return count;
    }


    // Zadanie programistyczne 3
    // Jeśli wypiszemy wszystkie liczby naturalne poniżej 10, które są wielokrotnościami 3 lub 5, otrzymamy 3, 5, 6 i 9. Suma tych wielokrotności wynosi 23.
    // Dokończ rozwiązanie tak, aby zwracało sumę wszystkich wielokrotności 3 lub 5 poniżej przekazanej liczby.
    // Uwaga: jeśli liczba jest wielokrotnością 3 i 5, policz ją tylko raz.

    public static int SumMultiples(int limit)
    {
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
}
