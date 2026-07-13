using System;

namespace Worde_Console
{
    public class WordleDisplay
    {
        public void PrintTopBottom()
        {
            Console.Write("--- ");
        }

        public void PrintLetter(char letter, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;

            Console.Write("| " + letter + " |");

            Console.ResetColor();
            Console.Write(" ");
        }
    }
}