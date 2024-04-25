namespace Zadania;

public class Program
{
    public static void Main(string[] args)
    {

    }

    // Zadanie programistyczne 1
    // Prawdopodobnie znasz system "polubień" z Facebooka i innych stron.Ludzie mogą "polubić" posty na blogu, zdjęcia lub inne elementy.
    // Chcemy utworzyć tekst, który powinien być wyświetlany obok takiego elementu.

    // Zaimplementuj funkcję, która pobiera tablicę zawierającą imiona osób, które polubiły dany element. 
    // Musi ona zwracać tekst wyświetlany tak, jak pokazano w przykładach:

    // [] --> "nikt tego nie lubi"
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
    // >>> CountSubstrings("ababababab", "aba")
    // 4
    // >>> CountSubstrings("banana", "na")
    // 2
    // >>> CountSubstrings("hello", "world")
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


    // Zadanie programistyczne 4
    // Pete lubi piec ciasta. Ma kilka przepisów i składników. Niestety nie jest dobry z matematyki. 
    // Czy możesz mu pomóc dowiedzieć się, ile ciast mógłby upiec, biorąc pod uwagę jego przepisy?

    // Napisz metodę Cakes(), która przyjmuje przepis (słownik <string, int>) i dostępne składniki (również słownik)
    // i zwraca maksymalną liczbę ciast, które Pete może upiec (liczba całkowita).
    // Dla uproszczenia nie ma jednostek dla ilości (np. 1 kilogram mąki lub 200 g cukru to po prostu 1 lub 200).
    // Składniki, które nie występują w obiektach, mogą być traktowane jako 0.

    // Przykłady:
    // >>> Cakes(new(){{"mąka", 500}, {"cukier", 200}, {"jajka", 1}}, 
    //           new(){{"mąka", 1200}, {"cukier", 1200}, {"jajka", 5}, {"mleko", 200}})
    // # musi zwrócić 2

    // >>> Cakes(new(){{"apples", 3}, {"mąka", 300}, {"cukier", 150}, {"mleko", 100}, {"olej", 100}}, 
    //           new(){{"cukier", 500}, {"mąka", 2000}, {"mleko", 2000}})
    // # musi zwrócić 0

    public static int Cakes(Dictionary<string, int> recipe, Dictionary<string, int> availableIngredients)
    {
        throw new NotImplementedException();
    }
}