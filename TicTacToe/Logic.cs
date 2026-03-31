namespace TicTacToe;

public static class Logic
{
    public static void InitializeGrid(char[,] grid)
    {    
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < Constants.SIZE_OF_THE_GRID; column++)
            {
                grid[row, column] = Constants.DASH_SYMBOL; 
            }
        }
    }
    
    public static bool CheckSlotAvailability(char[,] grid, int row, int column)
    {
        bool available = true;
        
        if (grid[row, column] == Constants.SYMBOL_USED_BY_MACHINE || grid[row, column] == Constants.SYMBOL_USED_BY_USER)
        {
            available = false;
        }
        
        return available;
    }
    
    public static char[,] PopulateGridWithUserSymbol(char[,] grid, int row, int column)
    {
        grid[row, column] = Constants.SYMBOL_USED_BY_USER;
        return grid;
    }
    
    public static char[,] PopulateGridWithMachineSymbol(char[,] grid)
    {
        Random rnd = new Random();
        int row = rnd.Next(0,3);
        int column = rnd.Next(0,3);
        
        grid [row,column] = Constants.SYMBOL_USED_BY_MACHINE;
        return grid;
    }

    public static bool CheckTheHorizontalLinesInTheGrid(char[,] grid)
    {
        bool match = true;
        
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < Constants.SIZE_OF_THE_GRID; column++)
            {
                if (grid[row, 0] != grid[row, column])
                {
                    if (grid[row, column] == Constants.DASH_SYMBOL)
                    {
                        return false;
                    }
                }
            }
        }
        return match;
    }

    public static bool CheckTheVerticalLinesInTheGrid(char[,] grid)
    {
        bool match = true;
        
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < Constants.SIZE_OF_THE_GRID; column++)
            {
                if (grid[0, column] != grid[row, column])
                {
                    if (grid[row, column] == Constants.DASH_SYMBOL)
                    {
                        return false;
                    }
                }
            }
        }
        return match;
    }
    
    public static bool CheckTheFirstDiagonalLineInTheGrid(char[,] grid)
    {
        bool match = true;
        
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            if (grid[0, 0] != grid[row, row])
            {
                if (grid[row, row] == Constants.DASH_SYMBOL)
                {
                    return false;
                }
            }
        }
        return match;
    }
    
    public static bool CheckTheSecondDiagonalLineInTheGrid(char[,] grid)
    {
        bool match = true;
        
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            if (grid[0, Constants.SIZE_OF_THE_GRID - 1] != grid[row, Constants.SIZE_OF_THE_GRID - row - 1])
            {
                if (grid[row, row] == Constants.DASH_SYMBOL)
                {
                    return false;
                }
            }
        }
        return match;
    }
    
    public static bool CheckIfWin(char[,] grid)
    {
        return Logic.CheckTheHorizontalLinesInTheGrid(grid) || Logic.CheckTheVerticalLinesInTheGrid(grid) || Logic.CheckTheFirstDiagonalLineInTheGrid(grid) || Logic.CheckTheSecondDiagonalLineInTheGrid(grid); 
    }
    
    public static char CheckWhoTheWinnerOfTheGameIs(char[,] grid, int row, int column)
    {
        if (CheckIfWin(grid))
        {
            //Horizontal lines 👇
            if (grid[row, 0] == grid[row, column])
            {
                return grid[row, 0];
            }
        
            //Vertical Lines 👇
            if (grid[0, column] == grid[row, column])
            {
                return grid[0, column];
            }
        
            //First diagonal line 👇
            if (grid[0, 0] != grid[row, row])
            {
                return grid[0, 0];
            }
        
            //Second diagonal line 👇
            if (grid[0, Constants.SIZE_OF_THE_GRID - 1] != grid[row, Constants.SIZE_OF_THE_GRID - row - 1])
            {
                return grid[0, Constants.SIZE_OF_THE_GRID - 1];
            }
        }
        
        return 'y';
    }
    
    public static bool CheckIfDraw (char[,] grid)
    {   
        bool draw = true;

        if (CheckIfWin(grid))
        {
            return false;
        }
        
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < Constants.SIZE_OF_THE_GRID; column++)
            {
                if (grid[row, column] == Constants.DASH_SYMBOL)
                {    
                    return false;
                }    
            }
        }
        
        return true;
    }    
}