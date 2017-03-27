using System;
using System.IO;

namespace HelloWorld
{
    public class Files
    {
        static void FilesReadWrite(string pathString)
        {
            //string path = @"c:\temp\MyTest.txt";
            if (!File.Exists(pathString))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(pathString))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(pathString))
            {
                string s = string.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void RunFileReadWrite()
        {
            string filepathString = Program.pathToProject + "FileReadWrite.txt";
            FilesReadWrite(filepathString);
        }
    }
}
