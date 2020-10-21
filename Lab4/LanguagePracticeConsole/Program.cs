using LanguageLibrary;
using System;

namespace LanguagePracticeConsole
{
    class Program
    {
        static void Main(string[] args) //video 29 command lines arguments
        {
            Folder.CreateMap();

            Console.WriteLine("Use any of the following parameters:");
            Console.WriteLine("lists");
            Console.WriteLine("new <listName><language 1><language 2>..<language n>");
            Console.WriteLine("add <listName>");
            Console.WriteLine("remove <listName><language><word 1><word 2>..<word n>");
            Console.WriteLine("words <listName><sortByLanguage>");
            Console.WriteLine("count <listName>");
            Console.WriteLine("practice <listName>");
            string[] userInput = Console.ReadLine().Split(' ');

            switch (userInput[0])
            {
                case "lists":
                    var files = WordList.GetLists();
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                    break;
                case "new":
                    string listName = userInput[1];
                    var languageNames = new string[userInput.Length - 2];
                    for (int i = 2; i < userInput.Length; i++)
                    {
                        languageNames[i - 2] = userInput[i];
                    }
                    var wordlist = new WordList(listName, languageNames);
                    wordlist.Save();
                    inputWords(listName);
                    break;
                case "add":
                    var wordList = WordList.LoadList(userInput[1]);
                    var languageArray = wordList.Languages;
                    bool inputNotEnter = true;
                    Console.WriteLine("Press enter to stop input.");
                    while (inputNotEnter)
                    {
                        var wordArray = new string[wordList.Languages.Length];

                        for (int i = 0; i < wordArray.Length; i++)
                        {
                            Console.WriteLine($"Write the {languageArray[i]} word.");
                            var words = Console.ReadLine();
                            wordArray[i] = words;
                            if (string.IsNullOrWhiteSpace(words))
                            {
                                inputNotEnter = false;
                                wordList.Save();
                                break;
                            }
                        }
                        wordList.Add(wordArray);
                    }
                    break;
                case "remove":
                    break;
                case "words":
                    var getList = WordList.LoadList(userInput[1]);
                    int languageNum = 0;

                    for (int i = 0; i < getList.Languages.Length; i++)
                    {
                        if (getList.Languages[i].ToLower() == userInput[2].ToLower())
                        {
                            languageNum = i;
                        }
                    }
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
                    var countList = WordList.LoadList(userInput[1]);
                    Console.WriteLine($"The list {userInput[1]} has {countList.Count()} words.");
                    break;
                case "practice":
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
            bool inputNotEnter = true;
            Console.WriteLine("Press enter to stop input");
            while (inputNotEnter)
            {
                var wordArray = new string[wordList.Languages.Length];

                for (int i = 0; i < wordArray.Length; i++)
                {
                    Console.Write($"Write the {wordList.Languages[i]} word:");
                    var words = Console.ReadLine();
                    wordArray[i] = words;
                    if (string.IsNullOrEmpty(words))
                    {
                        inputNotEnter = false;
                        wordList.Save();
                        break;
                    }
                }
                wordList.Add(wordArray);
            }
        }
    }
}
