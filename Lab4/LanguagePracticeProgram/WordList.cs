using System;
using System.CodeDom.Compiler;
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
            if (File.Exists(Folder.GetFilePath(fileName)))
            {
                using StreamReader sr = new StreamReader(Folder.GetFilePath(fileName));
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
            LoadList(fileName);
            var file = Folder.GetFilePath(fileName);
            using var fs = File.Create(Folder.GetFilePath(fileName));
            fs.Close();

            foreach (var language in Languages)
            {
                File.AppendAllText(file, language + ";");
            }
            foreach (var words in languageWords)
            {
                File.AppendAllText(file, "\n");

                for (int i = 0; i < Languages.Length; i++)
                {
                    File.AppendAllText(file, words.Translations[i] + ";");
                }
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
            return languageWords.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        //sortByTranslation = Vilket språk listan ska sorteras på.
        //showTranslations = Callback som anropas för varje ord i listan.
        {
            var sortedTranslations = languageWords.OrderBy(x => x.Translations[sortByTranslation]).ToArray();

            LoadList(fileName);
            foreach (var translation in sortedTranslations)
            {
                showTranslations(translation.Translations);
            }
        }

        public Word GetWordToPractice()
        //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
        //FromLanguage och ToLanguage(dock inte samma).
        {
            return null;
        }
    }
}
