namespace TicTacToe;

public static class UI
{
    public static void DisplayGameIntro()
    {
        Console.WriteLine("Let's play TicTacToe!");
        Console.WriteLine("\nPlease, place your symbol wherever you want to start playing :)");
    }
    
    public static void PrintGrid(char[,] grid)
    {   
        Console.WriteLine();
        
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < Constants.SIZE_OF_THE_GRID; column++)
            {
                Console.Write(grid[row, column]); 
            }
            Console.WriteLine();
        }
    }
    
    public static char GetRowNumberFromUser()
    {
        Console.WriteLine("\nChoose the row (0-2):");
        return Console.ReadKey(true).KeyChar;
    }
   
    public static char GetColumnNumberFromUser()
    {
        Console.WriteLine("\nChoose the column (0-2):");
        return Console.ReadKey(true).KeyChar;    
    }
    
    public static int ValidateUserInput(char input) 
    {
        while (true)
        {
            string userInputAsString = input.ToString();
            int userInput;

            bool valid = int.TryParse(userInputAsString, out userInput);
            
            if (!valid)
            {
                Console.WriteLine("\nInvalid Input"); 
                input = Console.ReadKey(true).KeyChar;
                continue;
            }

            if (userInput < 0 || userInput > 2) 
            {
                Console.WriteLine("\nPlease, make sure to choose a number between 0-2"); 
                input = Console.ReadKey(true).KeyChar;
                continue;
            }
            
            return userInput;
        }
    }
    
    public static void ShowMessageIfASlotIsTaken()
    {
        Console.WriteLine("\nSlot already occupied, try another one");
    }
    
    public static void ShowWinnerMessage()  
    {
        Console.WriteLine("\nYou've won the game :D");
    }
    
    public static void ShowLoserMessage()  
    {
        Console.WriteLine("\nYou've lost the game :(");
    }
    
    public static void ShowDrawMessage()  
    {
        Console.WriteLine("\nLooks like there has been a draw :O");
    }
}