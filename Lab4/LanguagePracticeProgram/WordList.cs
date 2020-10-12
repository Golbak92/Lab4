using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;


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
            var folderArray = Directory.GetFiles(Folder.SpecificFolder); //Hämtar filer från diretory i den mapp som är angiven i Folder.
            var languageArray = new string[folderArray.Length];

            for (int i = 0; i < folderArray.Length; i++) //Kollar igenom folderArrays index
            {
                languageArray[i] = Path.GetFileNameWithoutExtension(folderArray[i]);  //Sparar Filernas namn utan filändelsen i languageArray för att sedan returnera
            }
            return languageArray;
        }

        public static WordList LoadList(string name) //Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList.
        {
            return null;
        }

        public void Save() //Sparar listan till en fil med samma namn som listan och filändelse .dat 
        {
            string file = Folder.SpecificFolder + "\\" + Name + ".dat";
            using FileStream fs = File.Create(file);
            fs.Close();
            File.WriteAllLines(file, Languages);
            var lines = File.ReadLines(file);
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
