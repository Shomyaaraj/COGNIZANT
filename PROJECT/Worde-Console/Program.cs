using Worde_Console;

FileReader fileReader = new FileReader("fiveLetterWordbank.txt");
WordleDisplay wordleDisplay = new WordleDisplay();
WordleGame wordleGame = new WordleGame(fileReader, wordleDisplay);

wordleGame.Play();