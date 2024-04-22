import subprocess
import os

# Path to the executable file
exe_path = "./run_tests.exe"

# Get the current working directory
current_path = os.getcwd()

# Arguments to pass to the executable
arguments = [current_path]

# Construct the command to launch the executable with arguments
command = [exe_path] + arguments

# Run the executable with arguments
process = subprocess.Popen(command, cwd=current_path, stdout=subprocess.PIPE, stderr=subprocess.PIPE)

# Wait for the process to finish and capture the output
stdout, stderr = process.communicate()

# Check if the process was successful
if process.returncode == 0:
    print("Executable executed successfully!")
    print("Output:")
    print(stdout.decode())
else:
    print("Error executing executable:")
    print(stderr.decode())
