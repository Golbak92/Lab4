using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LanguageLibrary
{
    public static class Folder
    {
        public static string PathFolder => Environment.GetFolderPath((Environment.SpecialFolder.LocalApplicationData));

        public static string SpecificFolder => Path.Combine(PathFolder, "LanguagePracticeFiles");
        public static void CreateMap()
        {
            Directory.CreateDirectory(SpecificFolder);
        }
    }
}