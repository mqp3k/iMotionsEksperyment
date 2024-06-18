import re
# Zadanie programistyczne 1
# Prawdopodobnie znasz system "polubień" z Facebooka i innych stron.Ludzie mogą
# "polubić" posty na blogu, zdjęcia lub inne elementy.
# Chcemy utworzyć tekst, który powinien być wyświetlany obok takiego elementu.


# Zaimplementuj funkcję, która pobiera tablicę zawierającą imiona osób, które
# polubiły dany element.
# Musi ona zwracać tekst wyświetlany tak, jak pokazano w przykładach:


# [] --> "nikt tego nie lubi"
# [" Peter"] --> "Peter lubi to"
# ["Jacob", "Alex"] --> "Jacob i Alex lubią to"
# ["Max", "John", "Mark"] --> "Max, John i Mark lubią to"
# ["Alex", "Jacob", "Mark", "Max"] --> "Alex, Jacob i 2 inne osoby lubią to".
# Uwaga: W przypadku 4 lub więcej imion liczba w "i 2 inne…" po prostu wzrasta.

def whoLikesIt(names):
    num = len(names)
    if num==0:
        return "nikt tego nie lubi"
    if num ==1:
        return f'{names[0]} lubi to'
    out = ''
    for i,name in enumerate(names):
        if i<2:
            out.join(f'{name}, ')
        return out.join(f'i {num-i} osoby lubią to')
        

# Zadanie programistyczne 2
# Metoda CountSubstrings przyjmuje dwa łańcuchy znaków: 'baseString' i
# 'substring',
# a następnie zlicza wystąpienia podciągu 'substring' w łańcuchu 'baseString'.
# Parametry:
# - baseString: główny łańcuch znaków, w którym ma zostać przeszukany podciąg
# - substring: podciąg, który ma zostać znaleziony w łańcuchu 'string'
# Zwraca:
# - Liczba wystąpień podciągu 'substring' w łańcuchu 'baseString'

# Przykład użycia:
# >>> count_substrings("ababababab", "aba")
# 4
# >>> count_substrings("banana", "na")
# 2
# >>> count_substrings("hello", "world")
# 0

def countSubstrings(baseString, substring):
    match = re.findall(substring,baseString)
    if match:
        return len(match)
    return 0
    


# Zadanie programistyczne 3
# Jeśli wypiszemy wszystkie liczby naturalne poniżej 10, które są
# wielokrotnościami 3 lub 5, otrzymamy 3, 5, 6 i 9. Suma tych wielokrotności
# wynosi 23.
# Dokończ rozwiązanie tak, aby zwracało sumę wszystkich wielokrotności 3 lub 5
# poniżej przekazanej liczby.
# Uwaga: jeśli liczba jest wielokrotnością 3 i 5, policz ją tylko raz.

def sumMultiples(limit):
    sum=0
    for i in range(limit):
        sum += i if (i%3 ==0 or i%5==0 ) else 0
    return sum


# Zadanie programistyczne 4
# Pete lubi piec ciasta. Ma kilka przepisów i składników. Niestety nie jest dobry z matematyki. 
# Czy możesz mu pomóc dowiedzieć się, ile ciast mógłby upiec, biorąc pod uwagę jego przepisy?

# Napisz funkcję cakes(), która przyjmuje przepis (słownik <string, int>) i dostępne składniki (również słownik)
# i zwraca maksymalną liczbę ciast, które Pete może upiec (liczba całkowita).
# Dla uproszczenia nie ma jednostek dla ilości (np. 1 kilogram mąki lub 200g cukru to po prostu 1 lub 200).
# Składniki, które nie występują w obiektach, mogą być traktowane jako 0.

# Przykłady:
# >>> cakes({"mąka": 500, "cukier": 200, "jajka": 1}, 
#           {"mąka": 1200, "cukier": 1200, "jajka": 5, "mleko": 200})
# musi zwrócić 2

# >>> cakes({"apples": 3, "mąka": 300, "cukier": 150, "mleko": 100, "olej": 100}, 
#           {"cukier": 500, "mąka": 2000, "mleko": 2000})
# musi zwrócić 0

def cakes(recipe: dict, available: dict):
    if list(recipe.keys()) not in list(available.keys()):
        return 0
    count = 0
    while True:
        for k,v in available.items():
            available[k] = v-recipe[k]
        if available[k]<0:
            return count
    
