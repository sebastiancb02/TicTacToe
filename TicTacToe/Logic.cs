namespace TicTacToe;

public static class Logic
{
    char[,] ticTacToeGrid = new char [3, 3];

    //Make the evil AI machine 👇
    Random rnd = new Random();  
    
    //Now it’s the machine’s turn to place its symbol in the grid 👇
    ticTacToe [3,3] += rnd.Next(SYMBOL_USED_BY_MACHINE);
    
    //Check horizontal lines👇
    for (int row = 0; row < SIZE_OF_THE_GRID; row++)
    {
        for (int column = 0; column < SIZE_OF_THE_GRID; column++)
        {
            if (ticTacToeGrid[row, 0] != ticTacToeGrid[row, column])
            {
                match;
            }
        }
    }

    //Check vertical lines👇
    for (int row = 0; row < SIZE_OF_THE_GRID; row++)
    {
        for (int column = 0; column < SIZE_OF_THE_GRID; column++)
        {
            if (ticTacToeGrid[0, column] == ticTacToeGrid[row, column])
            {
                match;
            }
        }
    }

    //Check diagonal lines👇
    for (int row = 0; row < SIZE_OF_THE_GRID; row++)
    {
        if (ticTacToeGrid[0, 0] == ticTacToeGrid[row, row])
        {
            match;
        }
    }

    for (int row = 0; row < SIZE_OF_THE_GRID; row++)
    {
        if (ticTacToeGrid[0, SIZE_OF_THE_GRID - 1] == ticTacToeGrid[row, SIZE_OF_THE_GRID - row - 1])
        {
            match;
        }
    }
    
}