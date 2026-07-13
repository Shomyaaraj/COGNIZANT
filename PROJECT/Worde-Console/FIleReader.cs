using System;
using System.IO;

namespace Worde_Console
{
    public class FileReader
    {
        string filePath;

        public FileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public string GetRandomWord()
        {
            // Read every line of the file into a string array
            string[] words = File.ReadAllLines(filePath);

            // Create a random number generator
            Random random = new Random();

            // Pick a random index within the bounds of the array
            int randomIndex = random.Next(0, words.Length);

            // Return the word at that index
            return words[randomIndex];
        }
    }
}