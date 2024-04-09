namespace Zadania;

public class Program
{
    public static void Main(string[] args)
    {

    }

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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }


    // Zadanie programistyczne 3
    // Jeśli wypiszemy wszystkie liczby naturalne poniżej 10, które są wielokrotnościami 3 lub 5, otrzymamy 3, 5, 6 i 9. Suma tych wielokrotności wynosi 23.
    // Dokończ rozwiązanie tak, aby zwracało sumę wszystkich wielokrotności 3 lub 5 poniżej przekazanej liczby.
    // Uwaga: jeśli liczba jest wielokrotnością 3 i 5, policz ją tylko raz.

    public static int SumMultiples(int limit)
    {
        throw new NotImplementedException();
    }
}
