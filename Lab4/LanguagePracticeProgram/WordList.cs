﻿using System;
using System.IO;
using System.Linq;

namespace LanguageLibrary
{
    public class WordList
    {
        public WordList(string name, params string[] languages) //Konstruktor. Sätter properites Name och Languages till parametrarnas värden.
        {
            Name = name;
            Languages = languages;
        }

        public string Name { get; } //List name.
        public string[] Languages { get; } //Name of languages.

        public static string[] GetLists() //Returnerar array med namn på alla listor som finns lagrade (utan filändelsen).
        {
            var files = Directory.GetFiles(Folder.filesInDirectory)
                 .Select(f => Path.GetFileNameWithoutExtension(f))
                 .ToArray();
            return files;
        }

        public static WordList LoadList(string name) //Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList.
        {
            return null;
        }

        public void Save() //Sparar listan till en fil med samma namn som listan och filändelse .dat 
        {
            //using FileStream fs = File.Create(Folder.filesInDirectory + "\\" + Name + ".dat");
            var languages = "";
            for (int i = 0; i < Languages.Length; i++)
            {
                languages += Languages[i] + ";";
            }
            File.WriteAllText(Folder.filesInDirectory + "\\" + Name + ".dat", languages);
        }

        public void Add(params string[] translations) //Lägger till ord i listan. Kasta ArgumentException om det är fel antal translations.
        {
            
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
