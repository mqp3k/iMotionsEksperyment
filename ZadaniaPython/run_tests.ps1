param (
    [string]$scriptDirectory
)

# Ustalenie ścieżki do folderu nadrzędnego
$parentDirectory = Split-Path -Path $scriptDirectory -Parent
$env:PYTHONPATH = $scriptDirectory

# Ścieżka do folderu z testami
$unitTestingPath = Join-Path -Path $scriptDirectory -ChildPath "UnitTesting"

# Uruchomienie testów w Pythonie i przekierowanie wyjścia błędów na standardowe wyjście
$testOutput = & python -m unittest discover -s $unitTestingPath -v -p "*_test.py" 2>&1

# Inicjalizacja słownika wyników testów
$resultsDict = @{}

# Parsowanie wyników testów
$testOutput | ForEach-Object {
    # Sprawdź czy wiersz zawiera informacje o teście i jego wyniku
    if ($_ -match '\(([^)]+)\) \.\.\. (FAIL|ERROR|ok)') {
        $testName = $Matches[1].Split('.')[0]
        $testStatus = $Matches[2]

        # Zaktualizuj liczbę testów w zależności od wyniku
        switch ($testStatus) {
            "ok" { $success = 1; $failures = 0 }
            "FAIL" { $success = 0; $failures = 1 }
            "ERROR" { $success = 0; $failures = 1 }
        }

        # Sprawdź nazwę pliku testowego
        $testFile = ($testName -split '\(')[0].Trim()

        # Dodaj wynik do słownika
        if ($resultsDict.ContainsKey($testFile)) {
            $resultsDict[$testFile].Passed += $success
            $resultsDict[$testFile].Failed += $failures
        } else {
            $resultsDict[$testFile] = [PSCustomObject]@{
                TestFile = $testFile
                Passed = $success
                Failed = $failures
            }
        }
    }
}

# Zapisanie wyników do pliku CSV w folderze nadrzędnym
$outputCsv = Join-Path -Path $parentDirectory -ChildPath "output.csv"
$resultsDict.Values | Export-Csv -Path $outputCsv -NoTypeInformation

#Odkomentować żeby automatycznie uruchomić też skrypt zapisujący wyniki i resetujący gita
& "$($scriptDirectory)\..\save_output_and_git_reset.exe" "$($scriptDirectory)\.."