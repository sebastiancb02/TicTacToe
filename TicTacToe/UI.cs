namespace TicTacToe;

public static class UI
{
    //Some intro text 👇
    public static void Intro()
    {
        Console.WriteLine("Let's play TicTacToe!");
        Console.WriteLine("Please, place your symbol wherever you want to start playing :)");
    }
    
    //Show initial state of the game 👇
    public void InitialStateOfTheGame()
    {    
        for (int row = 0; row < SIZE_OF_THE_GRID; row++)
        {
            for (int column = 0; column < SIZE_OF_THE_GRID; column++)
            {
                ticTacToeGrid[row, column] = DASH_SYMBOLS;

                Console.WriteLine(DASH_SYMBOLS);
            }
            Console.WriteLine();
        }
    }

    //Let user choose row 👇
    public int GetRowNumberFromUser()
    {
        Console.WriteLine("Choose the row (0-2):");
        int playersRowPlacement = Convert.ToInt32(Console.ReadLine());
    }
    
    //Let user choose column 👇
    public int GetColumnNumberFromUser()
    {
        Console.WriteLine("Choose the row (0-2):");
        int playersColumnPlacement = Convert.ToInt32(Console.ReadLine());    
    }
}