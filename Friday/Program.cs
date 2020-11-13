using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string[] allDirectories = Directory.GetDirectories(rootPath);


            //ReadArray(allDirectories);
            string[] includeNestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            ReadArray(includeNestedDirectories);

            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);


        }

        public static void ReadArray(string[] array)
        {
            foreach (string line in array)
            {
                Console.WriteLine(line);
            }
            string filePath = @"C:\Users\opilane\Friday\sampleDirectories.txt";
            string directoryPathA = @"C:\Users\opilane\Friday\sampleFiles.txt";
            string directoryPath = @"C:\Users\opilane\samples";

            string[] filesA = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            string[] filesB = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filePath, filesB);
            File.WriteAllLines(directoryPath, filesA);

        }
    }
}
