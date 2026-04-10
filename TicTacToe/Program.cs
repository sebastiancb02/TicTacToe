namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        char[,] grid = new char [Constants.SIZE_OF_THE_GRID, Constants.SIZE_OF_THE_GRID];

        grid = Logic.InitializeGrid(grid);
        
        UI.DisplayGameIntro();

        UI.PrintGrid(grid);

        bool match = false;
        while (true)
        {
            int row = UI.ValidateUserInput(UI.GetRowNumberFromUser()); 
            int column = UI.ValidateUserInput(UI.GetColumnNumberFromUser());
            Console.Clear();
            
            bool available = Logic.CheckSlotAvailability(grid, row, column);
            
            if (!available)
            {
                UI.ShowMessageIfASlotIsTaken();
                continue;
            } 
            
            grid = Logic.PopulateGridWithUserSymbol(grid, row, column);
            
            Logic.CheckSlotAvailability(grid, row, column);

            match = Logic.CheckIfWin(grid);

            if (match)
            {
                UI.PrintGrid(grid);
                UI.ShowWinnerMessage();
                break;    
            }
            
            grid = Logic.PopulateGridWithMachineSymbol(grid);
            
            match = Logic.CheckIfWin(grid);

            if (match)
            {
                UI.PrintGrid(grid);
                UI.ShowLoserMessage();
                break;
            }
            
            bool draw =  Logic.CheckIfDraw(grid);
            if (draw)
            {
                UI.PrintGrid(grid);
                UI.ShowDrawMessage();
                break;
            }
            
            UI.PrintGrid(grid);
        }
    }
}