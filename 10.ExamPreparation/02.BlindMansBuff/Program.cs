using System;
using System.Linq;

int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];

int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < rows; row++)
{
    char[] columnsData = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = columnsData[col];

        if (matrix[row, col] == 'B')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

int movesMade = 0;
int touchedOpponents = 0;

string command;
while ((command = Console.ReadLine()) != "Finish")
{
    switch (command)
    {
        case "up":
            if (ValidateMove(playerRow - 1, playerCol, matrix))
            {
                movesMade++;

                matrix[playerRow, playerCol] = '-';

                if (matrix[playerRow - 1, playerCol] == 'P')
                {
                    touchedOpponents++;
                }

                playerRow--;

                matrix[playerRow, playerCol] = 'B';
            }
            break;
        case "down":
            if (ValidateMove(playerRow + 1, playerCol, matrix))
            {
                movesMade++;

                matrix[playerRow, playerCol] = '-';

                if (matrix[playerRow + 1, playerCol] == 'P')
                {
                    touchedOpponents++;
                }

                playerRow++;

                matrix[playerRow, playerCol] = 'B';
            }
            break;
        case "left":
            if (ValidateMove(playerRow, playerCol - 1, matrix))
            {
                movesMade++;

                matrix[playerRow, playerCol] = '-';

                if (matrix[playerRow, playerCol - 1] == 'P')
                {
                    touchedOpponents++;
                }

                playerCol--;

                matrix[playerRow, playerCol] = 'B';
            }
            break;
        case "right":
            if (ValidateMove(playerRow, playerCol + 1, matrix))
            {
                movesMade++;

                matrix[playerRow, playerCol] = '-';

                if (matrix[playerRow, playerCol + 1] == 'P')
                {
                    touchedOpponents++;
                }

                playerCol++;

                matrix[playerRow, playerCol] = 'B';
            }
            break;
    }

    if (touchedOpponents == 3)
    {
        break;
    }
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {movesMade}");

static bool ValidateMove(int row, int col, char[,] matrix)
{
    bool result = row >= 0
        && row < matrix.GetLength(0)
        && col >= 0
        && col < matrix.GetLength(1)
        && matrix[row, col] != 'O';

    return result;
}