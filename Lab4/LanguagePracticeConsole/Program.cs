using LanguageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string[] userInput = Console.ReadLine().Split(' ');

            switch (userInput[0])
            {
                case "-lists":
                    var files = WordList.GetLists();
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                    break;
                case "-new":
                    string listName = userInput[1];
                    var languageNames = new string[userInput.Length - 2];
                    for (int i = 2; i < userInput.Length; i++)
                    {
                        languageNames[i-2] = userInput[i];
                    }
                    var wordlist = new WordList(listName, languageNames);
                    wordlist.Save();
                    wordlist.Add();
                    break;
                case "-add":
                    break;
                case "-remove":
                    break;
                case "-words":
                    break;
                case "-count":
                    break;
                case "-practice":
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
