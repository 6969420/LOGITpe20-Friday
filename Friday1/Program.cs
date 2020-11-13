using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteFilePaths();

        }


        public static void WriteFilePaths()
        {
            string filePath = @"C:\Users\opilane\friday\samplefiles.txt";
            string directorypathA = @"C:\Users\opilane\friday\sampledirectories.txt";
            string directoryPath = @"C:\Users\opilane\samples";

            string[] filesA = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
            string[] filesB = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(directorypathA, filesA);
            File.WriteAllLines(filePath, filesB);
        }
    }
}