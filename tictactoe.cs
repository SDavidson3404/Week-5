// create 3x3 matrix for board

string[,] matrix = new string[3, 3] { {"Blank", "Blank", "Blank"}, {"Blank", "Blank", "Blank"}, {"Blank", "Blank", "Blank"} };

// Tic Tac Toe game

// define players

string currentPlayer = "X";

// define adding an x or o to the board

void AddToBoard(int row, int col)
{
    if (matrix[row - 1, col - 1] == "Blank")
    {
        matrix[row - 1, col - 1] = currentPlayer;
    }
    else
    {
        Console.WriteLine("Cell already occupied! Try again.");
    }
}

// define checking for a win

bool CheckWin()
{
    // check rows
    for (int i = 0; i < 3; i++)
    {
        if (matrix[i, 0] == currentPlayer && matrix[i, 1] == currentPlayer && matrix[i, 2] == currentPlayer)
        {
            return true;
        }
    }
    // check columns
    for (int i = 0; i < 3; i++)
    {
        if (matrix[0, i] == currentPlayer && matrix[1, i] == currentPlayer && matrix[2, i] == currentPlayer)
        {
            return true;
        }
    }
    // check diagonals
    if (matrix[0, 0] == currentPlayer && matrix[1, 1] == currentPlayer && matrix[2, 2] == currentPlayer)
    {
        return true;
    }
    if (matrix[0, 2] == currentPlayer && matrix[1, 1] == currentPlayer && matrix[2, 0] == currentPlayer)
    {
        return true;
    }
    return false;
}

// define checking for a tie

bool CheckTie()
{
    foreach (var cell in matrix)
    {
        if (cell == "Blank")
        {
            return false;
        }
    }
    return true;
}

// define switching players

void SwitchPlayer()
{
    currentPlayer = (currentPlayer == "X") ? "O" : "X";
}

// define displaying the board

void DisplayBoard()
{
    Console.WriteLine("Current Board:");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// define main game loop

while (true)
{
    DisplayBoard();
    Console.WriteLine($"Player {currentPlayer}, enter your move (row): ");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine($"Player {currentPlayer}, enter your move (column): ");
    int col = int.Parse(Console.ReadLine());
    AddToBoard(row, col);
    if (CheckWin())
    {
        DisplayBoard();
        Console.WriteLine($"Player {currentPlayer} wins!");
        break;
    }
    if (CheckTie())
    {
        DisplayBoard();
        Console.WriteLine("It's a tie!");
        break;
    }
    SwitchPlayer();
}

