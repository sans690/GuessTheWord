using System;

class Game
{
    static bool isCorrectLetter = false;
    static bool isCorrectWord = false;
    // static string? correctWord = "";
    static List<string> words = new List<string> { "dog", "cat", "house", "boat" };
    static List<string> word = new List<string> { };
    static List<char> chars = new List<char> { };
    static List<char> guessedChars = new List<char> { };


    public static void Run(string[] args)
    {
        MenuController.Menu();
    }

    public static void Start()
    {
        Random random = new Random();
        int selectedIndex = random.Next(0, words.Count());
        word.Add(words[selectedIndex]);
        char[] c = word[0].ToCharArray();

        for (int i = 0; i < c.Length; i++)
        {
            chars.Add(c[i]);
            Console.WriteLine(chars[i]);
        }

        do
        {
            Console.WriteLine("Guess a letter");
            string? letter = Console.ReadLine();
            char[]? guessedChar = letter?.ToCharArray();

            for (int i = 0; i < guessedChar?.Length; i++)
            {
                guessedChars.Add(guessedChar[i]);
                if (chars.Contains(guessedChars[i]))
                {
                    isCorrectLetter = true;
                    Console.WriteLine("This letter is in the word");
                }
            }
        }
        while (isCorrectWord == false);
    }
}
