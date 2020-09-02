using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Random\Pride and Prejudice by Jane Austen.txt";

            //string ContentsOfFile = File.ReadAllText(FilePath);

            var Lines = File.ReadAllLines(FilePath);

            for (int i = 0; i < Lines.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    string CurrentLine = Lines[i];
                    if (CurrentLine.Contains("Chapter"))
                    {
                        Console.ReadKey();
                    }
                }
                Console.WriteLine(Lines[i]);
            }

            Console.WriteLine(Lines);
        }
    }
}
