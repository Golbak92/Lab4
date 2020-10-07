using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLibrary
{
    public class Word
    {
        //Translations lagrar översättningarna, en för varje språk. Med FromLanguage och
        //ToLanguage kan man ange för övningar vilket språk som ska översättas till
        //respektive från.Dessa används av metoden WordList.GetWordToPractice()

        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            //initialiserar ’Translations’ med data som skickas in som ’translations’ 
        }

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            //som ovan, fast sätter även FromLanguage och ToLanguage.
        }
    }
}
