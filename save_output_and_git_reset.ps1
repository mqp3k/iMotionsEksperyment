param (
    [string]$scriptDirectory
)

# Prompt the user to input the filename
$newFilename = Read-Host "Enter your name:"

# Generate a new GUID
$guid = [guid]::NewGuid().ToString()

# Define the source directory, destination directory, and original filename
$sourceDirectory = $scriptDirectory
$destinationDirectory = Join-Path -Path $scriptDirectory -ChildPath "./results"
$originalFilename = "output.csv"

# Check if the source file exists
$sourceFilePath = Join-Path -Path $sourceDirectory -ChildPath $originalFilename
if (-not (Test-Path -Path $sourceFilePath -PathType Leaf)) {
    Write-Host "Error: File '$originalFilename' not found in directory '$sourceDirectory'"
    Exit
}

# Create the destination directory if it doesn't exist
if (-not (Test-Path -Path $destinationDirectory -PathType Container)) {
    New-Item -Path $destinationDirectory -ItemType Directory | Out-Null
}

# Append the GUID to the output filename
$outputFilename = "$newFilename-$guid.csv"

# Move the file to the destination directory with the new filename
$destinationFilePath = Join-Path -Path $destinationDirectory -ChildPath $outputFilename
Move-Item -Path $sourceFilePath -Destination $destinationFilePath -Force
Write-Host "File '$originalFilename' moved successfully to '$destinationFilePath' with the new filename '$outputFilename'"

# Use Git to stash changes
git stash

# Revert to the last commit
git reset --hard HEAD