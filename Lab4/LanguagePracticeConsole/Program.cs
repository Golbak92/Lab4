using LanguageLibrary;
using System;

namespace LanguagePracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pressEnterToStop = true;
            Folder.CreateMap();

            Console.WriteLine("Use any of the following parameters:\n");
            Console.WriteLine("lists");
            Console.WriteLine("new <listName><language 1><language 2>..<language n>");
            Console.WriteLine("add <listName>");
            Console.WriteLine("remove <listName><language><word 1><word 2>..<word n>");
            Console.WriteLine("words <listName><sortByLanguage>");
            Console.WriteLine("count <listName>");
            Console.WriteLine("practice <listName>\n");
            Console.WriteLine("Enter your parameter here: ");

            switch (args[0])
            {
                case "lists":
                    var files = WordList.GetLists();
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                    break;
                case "new":
                    string listName = args[1];
                    var languageNames = new string[args.Length - 2];
                    for (int i = 2; i < args.Length; i++)
                    {
                        languageNames[i - 2] = args[i];
                    }
                    var wordlist = new WordList(listName, languageNames);
                    wordlist.Save();
                    inputWords(listName);
                    break;
                case "add":
                    var wordList = WordList.LoadList(args[1]);
                    var languageArray = wordList.Languages;
                    Console.WriteLine("\nPress enter to stop input.");
                    while (pressEnterToStop)
                    {
                        var wordArray = new string[wordList.Languages.Length];

                        for (int i = 0; i < wordArray.Length; i++)
                        {
                            Console.WriteLine($"Write the {languageArray[i]} word.");
                            var words = Console.ReadLine();
                            wordArray[i] = words;
                            if (string.IsNullOrWhiteSpace(words))
                            {
                                pressEnterToStop = false;
                                wordList.Save();
                                break;
                            }
                        }
                        wordList.Add(wordArray);
                    }
                    break;
                case "remove":
                    var removeWords = WordList.LoadList(args[1]);
                    var languageInt = 0;

                    for (int i = 0; i < removeWords.Languages.Length; i++)
                    {
                        if (removeWords.Languages[i] == args[2])
                        {
                            languageInt = i;
                        }
                    }

                    for (int i = 3; i < args.Length; i++)
                    {
                        removeWords.Remove(languageInt, args[i]);
                    }
                    removeWords.Save();
                    break;
                case "words":
                    var getList = WordList.LoadList(args[1]);
                    int languageNum = 0;

                    for (int i = 0; i < getList.Languages.Length; i++)
                    {
                        if (getList.Languages[i].ToLower() == args[2].ToLower())
                        {
                            languageNum = i;
                        }
                    }
                    Console.WriteLine();
                    foreach (var languages in getList.Languages)
                    {
                        Console.Write(languages.PadRight(20).ToUpper());
                    }
                    Console.WriteLine();
                    getList.List(languageNum, x =>
                    {
                        foreach (var words in x)
                        {
                            Console.Write(words.PadRight(20));
                        }
                        Console.WriteLine();
                    });
                    break;
                case "count":
                    var countList = WordList.LoadList(args[1]);
                    Console.WriteLine($"\nThe listname '{args[1]}' has {countList.Count()} words.");
                    break;
                case "practice":
                    var practiceList = WordList.LoadList(args[1]);

                    var correctAnswer = 0;

                    while (pressEnterToStop)
                    {
                        var wordTrainer = practiceList.GetWordToPractice();
                        Console.WriteLine($"\nThe randomized languages you get to practice on are from: " +
                            $"'{practiceList.Languages[wordTrainer.FromLanguage]}' " +
                            $"to: '{practiceList.Languages[wordTrainer.ToLanguage]}'");
                        Console.WriteLine($"Type the correct answer of '{wordTrainer.Translations[wordTrainer.FromLanguage]}'");
                        var input = Console.ReadLine();

                        if (input == wordTrainer.Translations[wordTrainer.ToLanguage])
                        {
                            Console.WriteLine("Congratulations! The answer is correct!");
                            correctAnswer++;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, The answer is wrong!");
                        }

                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine($"You got {correctAnswer} points");
                            pressEnterToStop = false;
                            break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
            Console.ReadLine();
        }

        public static void inputWords(string name)
        {
            var wordList = WordList.LoadList(name);
            bool pressEnterToStop = true;
            Console.WriteLine("Press enter to stop input");
            while (pressEnterToStop)
            {
                var wordArray = new string[wordList.Languages.Length];

                for (int i = 0; i < wordArray.Length; i++)
                {
                    Console.Write($"Write the {wordList.Languages[i]} word:");
                    var words = Console.ReadLine();
                    wordArray[i] = words;
                    if (string.IsNullOrEmpty(words))
                    {
                        pressEnterToStop = false;
                        wordList.Save();
                        break;
                    }
                }
                wordList.Add(wordArray);
            }
        }
    }
}
