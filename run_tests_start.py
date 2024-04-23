import subprocess
import sys
import os
import tkinter as tk

def check_entry():
    # Get the name entered by the user
    name = name_entry.get()

    # Check if the name field is empty
    if not name:
        execute_button.config(state='disabled')
    else:
        execute_button.config(state='normal')

def execute_script():
    # Get the name entered by the user
    name = name_entry.get()

    current_path = sys.argv[0]

    # Path to the executable file
    exe_path = os.path.join(current_path, "./run_tests.exe")

    # Arguments to pass to the executable
    arguments = [current_path, name]

    # Construct the command to launch the executable with arguments
    command = [exe_path] + arguments

    # Run the executable with arguments
    process = subprocess.Popen(command, cwd=current_path, stdout=subprocess.PIPE, stderr=subprocess.PIPE)

    # Wait for the process to finish and capture the output
    stdout, stderr = process.communicate()

    # Check if the process was successful
    if process.returncode == 0:
        output_text.config(text=f"Dziękujemy za udział w badaniu :)")
    else:
        output_text.config(text=f"Wystąpił błąd podczas wykonywania skryptu:\n{stderr.decode()}")

    # Show the exit button after script execution
     # Hide the name entry field
    name_label.grid_remove()
    name_entry.grid_remove()
    execute_button.grid_remove()

    # Show the exit button after script execution
    exit_button.grid()

# Create the main window
app = tk.Tk()
app.title("Wykonywanie Skryptu")

# Create a frame for better organization
frame = tk.Frame(app)
frame.pack(padx=20, pady=20)

# Create a label and entry for entering name
name_label = tk.Label(frame, text="Podaj swój identyfikator:", font=("Arial", 12))
name_label.grid(row=0, column=0, sticky="w")

name_entry = tk.Entry(frame, width=40, font=("Arial", 12))
name_entry.grid(row=1, column=0, padx=(0, 10), pady=5)

# Create a button to execute the script
execute_button = tk.Button(frame, text="Dalej", command=execute_script, width=15, font=("Arial", 12))
execute_button.grid(row=1, column=1, pady=5)

# Create a label to display output
output_text = tk.Label(frame, text="", wraplength=400, font=("Arial", 12))
output_text.grid(row=2, column=0, columnspan=2, pady=10)

# Create a button to exit the application (hidden initially)
exit_button = tk.Button(frame, text="Zakończ", command=app.quit, width=15, font=("Arial", 12))
exit_button.grid(row=3, column=0, columnspan=2, pady=(5, 0))
exit_button.grid_remove()  # Hide the exit button initially

# Check the entry field whenever it changes
name_entry.bind("<KeyRelease>", lambda event: check_entry())

# Start the event loop
app.mainloop()
