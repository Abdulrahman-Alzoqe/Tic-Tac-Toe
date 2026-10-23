# Tic Tac Toe

A two-player Tic Tac Toe game for Windows, built with **C#** and **Windows Forms** using **Guna UI2**.
The project focuses on a clean visual identity: charcoal grays, a single coral accent, soft shadow backgrounds, and a white board card.

<img width="1225" height="686" alt="Screenshot 2026-10-23 142041" src="https://github.com/user-attachments/assets/5c09f418-d291-4e1a-ac51-956c8cccb318" />

## Features

- Two players on the same computer (Player 1 = X, Player 2 = O)
- Win and draw detection for all 8 winning lines
- Cells lock after being played, and the board locks when the game ends
- Turn indicator and winner label
- Restart button to start a new round
- Custom artwork: X/O marks, board, panels, and buttons

## Tech Stack

- C# / .NET Framework
- Windows Forms
- [Guna UI2 WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms)

## Getting Started

1. Clone the repository:
```
   git clone https://github.com/<Abdulrahman-Alzoqe>/<Tic-Tac-Toe>.git
```
2. Open the `.sln` file in **Visual Studio**.
3. Restore NuGet packages (right-click the solution, then **Restore NuGet Packages**). Guna.UI2.WinForms is required.
4. Press **F5** to build and run.

## How It Works

Each cell stores its own state, and the winner is found by checking the 8 winning lines (3 rows, 3 columns, 2 diagonals) against that state.
Comparing images directly does not work, because every read from `Resources` returns a new object, so the game keeps the logic separate from what is drawn on screen.
