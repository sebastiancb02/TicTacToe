namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        char[,] grid = new char [Constants.SIZE_OF_THE_GRID, Constants.SIZE_OF_THE_GRID];

        Logic.InitializeGrid(grid);
        
        UI.DisplayGameIntro();

        UI.PrintGrid(grid);

        bool match = true;
        while (!match)
        {
            int row = UI.ValidateUserInput(UI.GetRowNumberFromUser()); 
            int column = UI.ValidateUserInput(UI.GetColumnNumberFromUser());

            bool available = Logic.CheckSlotAvailability(grid, row, column);
            if (!available)
            {
                UI.ShowMessageIfASlotIsTaken();
                continue;
            } 
            
            grid = Logic.PopulateGridWithUserSymbol(grid, row, column);
            
            Logic.PopulateGridWithMachineSymbol(grid);
            
            Logic.CheckSlotAvailability(grid, row, column);

            match = Logic.CheckIfWin(grid);

            if (match)
            {
                char winningSymbol = Logic.CheckWhoTheWinnerOfTheGameIs(grid, row, column);
            
                if (winningSymbol == Constants.SYMBOL_USED_BY_USER)
                {
                    UI.ShowWinnerMessage();
                    UI.PrintGrid(grid);
                    break;
                }
            
                if (winningSymbol == Constants.SYMBOL_USED_BY_MACHINE)
                {
                    UI.ShowLoserMessage();
                    UI.PrintGrid(grid);
                    break;
                }    
            }
            //TODO add else case to check for draw scenario

            else
            {
                bool draw =  Logic.CheckIfDraw(grid);

                if (draw)
                {
                    UI.ShowDrawMessage();
                }
            }
            
            UI.PrintGrid(grid);
        }
        

    }
    
}