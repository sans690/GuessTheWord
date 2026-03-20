using System;

class Game
{
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
            for (int i = 0; i < chars.Count; i++)
            {
                Console.WriteLine("Enter a letter:");
                string? letter = Console.ReadLine();

                char guessedChar = letter[0];

                if (chars.Contains(guessedChar))
                {
                    guessedChars.Add(guessedChar);
                    Console.WriteLine("The letter is in the word");
                }
                if (!chars.Contains(guessedChar))
                {
                    Console.WriteLine("The letter is not in the word");
                }

                else if (string.IsNullOrWhiteSpace(letter) || letter.Length != 1)
                {
                    Console.WriteLine("The value entered contains either a whitespace or the input is the wrong length");
                    Console.WriteLine("Enter a single letter next time");
                    i--;
                    continue;
                }

                bool isInt = int.TryParse(letter, out int intLetter);

                if (isInt)
                {
                    Console.WriteLine("The value entered was a number, which is invalid ");
                    Console.WriteLine("Enter a single letter next time");
                    i--;
                    continue;
                }

                if (chars.Count == guessedChars.Count)
                {
                    Console.WriteLine($"\nYou guessed the correct word: {string.Join("", chars)}");
                    isCorrectWord = true;
                }
            }
        }
        while (isCorrectWord == false);
    }
}
