using LanguageLibrary;
using System;

namespace LanguagePracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder.CreateMap();

            Console.WriteLine("Use any of the following parameters:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <listName><language 1><language 2>..<language n>");
            Console.WriteLine("-add <listName>");
            Console.WriteLine("-remove <listName><language><word 1><word 2>..<word n>");
            Console.WriteLine("-words <listName><sortByLanguage>");
            Console.WriteLine("-count <listName>");
            Console.WriteLine("-practice <listName>");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "lists":
                    var languageArray = WordList.GetLists();

                    foreach (var languages in languageArray)
                    {
                        Console.WriteLine();
                        Console.WriteLine(languages);
                    }
                    break;

                case "new":
                    Console.WriteLine("skriv");
                    var read = Console.ReadLine().Split(' ');
                    var name = read[0];
                    var copyArray = new string[read.Length - 1];

                    for (int i = 1; i < read.Length; i++)
                    {
                        copyArray[i - 1] = read[i];
                    }

                    var wordList = new WordList(name, copyArray);
                    wordList.Save();
                    wordList.Add();

                    break;

                case "add":
                    break;
                case "remove":
                    break;
                case "words":
                    break;
                case "count":
                    break;
                case "practice":
                    break;

                default:
                    Console.WriteLine();
                    break;
            }

            Console.ReadLine();
        }
    }
}
