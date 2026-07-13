using System;

namespace Worde_Console
{
    public class WordleGame
    {
        const int MAX_GUESSES = 6;
        string secretWord;
        int totalGuesses;
        bool isWin;

        FileReader _fileReader;
        WordleDisplay _wordleDisplay;

        public WordleGame(FileReader fileReader, WordleDisplay wordleDisplay)
        {
            _fileReader = fileReader;
            _wordleDisplay = wordleDisplay;
           
            secretWord = _fileReader.GetRandomWord();
            totalGuesses = 0;
            isWin = false;
        }

        private string GetUserGuess()
        {
            string guess = "";

            do
            {
                Console.WriteLine("Enter your 5 letter word guess: ");
                guess = (Console.ReadLine() ?? "").ToLower();

                if (guess.Length != secretWord.Length)
                {
                    Console.WriteLine("Invalid guess. Must be 5 letters");
                }
            } while (guess.Length != secretWord.Length);

            totalGuesses++;
            return guess;
        }

     private void EvaluateGuess(string guess)
{
    // Top horizontal lines for boxes
    for (int n = 0; n < guess.Length; n++)
    {
        _wordleDisplay.PrintTopBottom();
    }
    Console.WriteLine();

    // Set up result array and the "pool" of remaining secret letters
    ConsoleColor[] resultColors = new ConsoleColor[guess.Length];
    List<char> remainingLetters = new List<char>(secretWord.ToCharArray());

    // PASS 1: find all exact matches (greens) first
    for (int n = 0; n < guess.Length; n++)
    {
        if (guess[n] == secretWord[n])
        {
            resultColors[n] = ConsoleColor.Green;
            remainingLetters.Remove(guess[n]); // use up this letter from the pool
        }
    }

    // PASS 2: for everything not already green, check against the remaining pool
    for (int n = 0; n < guess.Length; n++)
    {
        if (resultColors[n] == ConsoleColor.Green)
        {
            continue; // already handled in pass 1, skip it
        }

        if (remainingLetters.Contains(guess[n]))
        {
            resultColors[n] = ConsoleColor.Yellow;
            remainingLetters.Remove(guess[n]); // use up this letter from the pool
        }
        else
        {
            resultColors[n] = ConsoleColor.Black;
        }
    }

    // Print the letters using the colors we calculated
    for (int n = 0; n < guess.Length; n++)
    {
        ConsoleColor foreground = resultColors[n] == ConsoleColor.Black ? ConsoleColor.White : ConsoleColor.Black;
        _wordleDisplay.PrintLetter(guess[n], resultColors[n], foreground);
    }
    Console.WriteLine();

    // Bottom horizontal lines for boxes
    for (int n = 0; n < guess.Length; n++)
    {
        _wordleDisplay.PrintTopBottom();
    }
    Console.WriteLine();

    if (guess == secretWord)
    {
        isWin = true;
    }
}

        public void Play()
        {
            Console.WriteLine("Let's play Wordle!!");

            while (totalGuesses < MAX_GUESSES && !isWin)
            {
                string guess = GetUserGuess();
                EvaluateGuess(guess);
            }

            if (isWin)
            {
                Console.WriteLine("You won! The secret word was: " + secretWord);
            }
            else
            {
                Console.WriteLine("You lost... the secret word was: " + secretWord);
            }
        }
    }
}