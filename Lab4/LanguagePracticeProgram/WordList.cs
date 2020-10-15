using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LanguageLibrary
{
    public class WordList
    {
        private List<Word> languageWords = new List<Word>();
        public WordList(string fileName, params string[] languages) //Konstruktor. Sätter properites Name och Languages till parametrarnas värden.
        {
            this.fileName = fileName;
            Languages = languages;
        }

        public string fileName { get; } //List name.
        public string[] Languages { get; } //Name of languages.

        public static string[] GetLists() //Returnerar array med namn på alla listor som finns lagrade (utan filändelsen).
        {
            var files = Directory.GetFiles(Folder.filesInDirectory)
                 .Select(f => Path.GetFileNameWithoutExtension(f))
                 .ToArray();
            return files;
        }

        public static WordList LoadList(string fileName) //Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList.
        {
            if (File.Exists(Folder.filesInDirectory + "\\" + fileName + ".dat"))
            {
                using StreamReader sr = new StreamReader(Folder.filesInDirectory + "\\" + fileName + ".dat");
                var languages = sr.ReadLine().TrimEnd(';').Split(';');
                WordList wordList = new WordList(fileName, languages);
                while (!sr.EndOfStream)
                {
                    var translations = sr.ReadLine().TrimEnd(';').Split(';');
                    wordList.Add(translations);
                }
                return wordList;
            }
            return null;
        }

        public void Save() //Sparar listan till en fil med samma namn som listan och filändelse .dat 
        {

            if (File.Exists(Folder.filesInDirectory + "\\" + fileName + ".dat"))
            {
                LoadList(fileName);
                StreamWriter addWords = new StreamWriter(Folder.filesInDirectory + "\\" + fileName + ".dat", false);

                for (int i = 0; i < Languages.Length; i++)
                {
                    foreach (var wordArray in languageWords)
                    {
                        foreach (var translation in wordArray.Translations)
                        {
                            addWords.WriteLine($"\n{translation} + ;");
                        }
                    }
                }
            }
            else
            {
                var languages = "";
                for (int i = 0; i < Languages.Length; i++)
                {
                    languages += Languages[i] + ";";
                }
                File.AppendAllText(Folder.filesInDirectory + "\\" + fileName + ".dat", languages);

                var words = "";
                for (int i = 0; i < languageWords.Count; i++)
                {
                    words += languageWords[i] + ";";
                }
                File.AppendAllText(Folder.filesInDirectory + "\\" + fileName + ".dat", words + ";");
            }
        }

        public void Add(params string[] translations) //Lägger till ord i listan. Kasta ArgumentException om det är fel antal translations.
        {
            if (translations.Length == Languages.Length)
            {
                languageWords.Add(new Word(translations));
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public bool Remove(int translation, string word) //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet.
        {
            return true;
        }

        public int Count() //Räknar och returnerar antal ord i listan.
        {
            return 0;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        //sortByTranslation = Vilket språk listan ska sorteras på.
        //showTranslations = Callback som anropas för varje ord i listan.
        {
        }

        public Word GetWordToPractice()
        //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
        //FromLanguage och ToLanguage(dock inte samma).
        {
            return null;
        }
    }
}
