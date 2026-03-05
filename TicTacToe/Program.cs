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
            int row = UI.GetRowNumberFromUser(); //How can it be int if the input is a char?
            int column = UI.GetColumnNumberFromUser(); //Same here

            UI.ValidateUserInput(); //Validate row input
            UI.ValidateUserInput(); //Validate column input

            bool available = Logic.CheckSlotAvailability(grid, row, column);
            
            if (!available)
            {
                UI.ShowMessageIfASlotIsTaken();    
            } 
            
            grid = Logic.PopulateGridWithUserSymbol(grid, row, column); //Why the part with "grid ="?
            
            Logic.PopulateGridWithMachineSymbol(grid);
            
            Logic.CheckSlotAvailability(grid, row, column);
            
            bool match = Logic.CheckTheHorizontalLinesInTheGrid(grid);
            bool match = Logic.CheckTheVerticalLinesInTheGrid(grid);
            bool match = Logic.CheckTheDiagonalLinesInTheGrid(grid);
        }
        

    }
    
}