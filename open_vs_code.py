import subprocess
import tkinter as tk
from tkinter import messagebox
import os
import sys

def launch_vscode():
    try:
        if len(sys.argv) != 4:
            messagebox.showerror("Error", "Unsupported number of arguments.")
            return
        
        # Get paths from command line arguments
        vscode_path = sys.argv[1]
        project_path = sys.argv[2]
        file_path = sys.argv[3]

        # Check if paths exist
        if not os.path.exists(vscode_path):
            messagebox.showerror("Error", "VS Code path does not exist.")
            return
        if not os.path.exists(project_path):
            messagebox.showerror("Error", "Project path does not exist.")
            return
        if not os.path.exists(file_path):
            messagebox.showerror("Error", "File path does not exist.")
            return

        # Launch VS Code with project path and file
        subprocess.Popen([vscode_path, project_path, file_path])
    except Exception as e:
        messagebox.showerror("Error", f"Failed to launch VS Code: {e}")

def minimize_window():
    app.iconify()

# Create the main window
app = tk.Tk()
app.title("VS Code Launcher")

# Add a frame to hold the buttons
button_frame = tk.Frame(app)
button_frame.grid(row=3, columnspan=2, padx=10, pady=20)

# Add a button to launch VS Code
launch_button = tk.Button(button_frame, text="Launch VS Code", command=launch_vscode, width=15)
launch_button.pack(side="left", padx=10)

# Add a button to minimize the window
minimize_button = tk.Button(button_frame, text="Minimize Window", command=minimize_window, width=15)
minimize_button.pack(side="left", padx=10)

# Start the event loop
launch_vscode()
app.mainloop()
