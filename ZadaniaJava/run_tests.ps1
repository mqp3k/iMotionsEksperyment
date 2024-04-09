param (
    [string]$scriptDirectory
)

# Ścieżki do katalogów projektu
$libPath = Join-Path -Path $scriptDirectory -ChildPath "lib"
$unitTestingPath = Join-Path -Path $scriptDirectory -ChildPath "ZadaniaJava\UnitTesting"
$tasksPath = Join-Path -Path $scriptDirectory -ChildPath "ZadaniaJava\Zadania"
$outPath = Join-Path -Path $scriptDirectory -ChildPath "out"

# Tworzenie katalogu wyjściowego, jeśli nie istnieje
if (-not (Test-Path $outPath)) {
    New-Item -ItemType Directory -Path $outPath
}

# Tworzenie classpath
$cp = "$libPath\*;$outPath"

# Kompilacja kodu źródłowego i testowego
javac -d $outPath -cp $cp $(Get-ChildItem -Recurse -Path $tasksPath, $unitTestingPath -Filter *.java).FullName

# Wyszukiwanie nazw klas testowych
$testFiles = Get-ChildItem -Path $unitTestingPath -Filter *Tests.java
$testClasses = $testFiles.ForEach({ [System.IO.Path]::GetFileNameWithoutExtension($_.Name) })

# Inicjalizacja listy wyników
$resultsList = @()

# Uruchamianie testów JUnit dla każdej znalezionej klasy testowej
foreach ($testClass in $testClasses) {
    # Uruchomienie testów i zapisanie wyników do zmiennej
    $testResult = java -cp $cp org.junit.runner.JUnitCore "ZadaniaJava.UnitTesting.$testClass"

    # Analiza wyników
    if ($testResult -match "FAILURES!!!") {
        $failures = ($testResult -match "Failures: (\d+)")[0] -replace ".*Failures: (\d+).*", '$1'
        $testsRun = ($testResult -match "Tests run: (\d+),")[0] -replace ".*Tests run: (\d+),.*", '$1'
        $success = $testsRun - $failures
    } else {
        $failures = 0
        $success = ($testResult -match "OK \((\d+) tests\)")[0] -replace ".*OK \((\d+) tests\).*", '$1'
    }

    # Dodanie wyników do listy
    $resultsList += [PSCustomObject]@{
        TestName = $testClass
        Passed = $success
        Failed = $failures
    }
}

# Zapisanie wyników do pliku CSV
$resultsList | Export-Csv -Path "$scriptDirectory\..\output.csv" -NoTypeInformation

Write-Host "Test results saved to $scriptDirectory\..\output.csv"

# Usunięcie folderu out
Remove-Item -Path $outPath -Recurse -Force

#Odkomentować żeby automatycznie uruchomić też skrypt zapisujący wyniki i resetujący gita
#& "$($scriptDirectory)\..\save_output_and_git_reset.exe" "$($scriptDirectory)\.."