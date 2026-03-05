namespace TicTacToe;

public static class UI
{
    public static void DisplayGameIntro()
    {
        Console.WriteLine("Let's play TicTacToe!");
        Console.WriteLine("Please, place your symbol wherever you want to start playing :)");
    }
    
    public static void PrintGrid(char[,] grid)
    {    
        for (int row = 0; row < Constants.SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < Constants.SIZE_OF_THE_GRID; column++)
            {
                Console.WriteLine(grid[row, column]); 
            }
            Console.WriteLine();
        }
    }
    
    public static int GetRowNumberFromUser()
    {
        Console.WriteLine("Choose the row (0-2):");
        return Convert.ToInt32(Console.ReadKey().KeyChar);
    }
   
    public static int GetColumnNumberFromUser()
    {
        Console.WriteLine("Choose the row (0-2):");
        return Convert.ToInt32(Console.ReadKey().KeyChar);    
    }
    
    public static int ValidateUserInput() //Maybe there's a better way to convert char to int?
    {
        while (true)
        {
            char userInputAsChar = Console.ReadKey(true).KeyChar;
            string userInputAsString = userInputAsChar.ToString();
            int userInput;

            bool valid = int.TryParse(userInputAsString, out userInput);
            
            if (!valid)
            {
                Console.WriteLine("Invalid Input"); 
                continue;
            }

            if (userInput < 0 || userInput > 2) 
            {
                Console.WriteLine("Please make sure to choose a number between 0-2"); 
                continue;
            }
        }
    }
    
    public static void ShowMessageIfASlotIsTaken()
    {
        Console.WriteLine("Slot already occupied, try another one");
    }
}