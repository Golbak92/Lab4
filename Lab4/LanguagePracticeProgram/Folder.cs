using System;
using System.IO;

namespace LanguagePracticeProgram
{
    public class Folder
    {
        public static void CreateMap()
        {
            // The folder for the roaming current user 
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // Combine the base folder with your specific folder....
            string specificFolder = Path.Combine(folder, "test");

            // CreateDirectory will check if folder exists and, if not, create it.
            // If folder exists then CreateDirectory will do nothing.
            Directory.CreateDirectory(specificFolder);
        }    
    }
}