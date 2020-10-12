using System;
using System.Dynamic;
using System.IO;

namespace LanguageLibrary
{
    public static class Folder
    {
        public static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string filesInDirectory = Path.Combine(filePath, "LanguagePracticeFiles");

        public static void CreateMap()
        {
            // CreateDirectory will check if folder exists and, if not, create it.
            // If folder exists then CreateDirectory will do nothing.
            Directory.CreateDirectory(filesInDirectory);
        }    
    }
}