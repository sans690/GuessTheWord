using System;

class MenuController
{
    public static void Menu()
    {
        Console.WriteLine("Welcome to GuessTheWord!");
        Console.WriteLine("Select an option to begin");
        Console.WriteLine("1. Start game");
        Console.WriteLine("2. Exit");
        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                try
                {
                    Game.Start();
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }
                break;

            case "2":
                try
                {
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }
                break;
        }
    }
}