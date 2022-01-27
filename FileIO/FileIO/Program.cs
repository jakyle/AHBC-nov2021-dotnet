using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Absolute Path, windows versus Linux / mac, absolute paths 
            // point the physcal static location in your file directory, always
            // starts at the hard drive, and paths all the way to the file or directory that 
            // it's pathing too.
            // AS A DEV, YOU WANT TO AVOID USING ABSOLUTE PATHING
            // C:\Users\jjack\OneDrive\Documents\2018_W2_201928133958.pdf
            // C:/Users/jjack/OneDrive/Documents/2018_W2_201928133958.pdf


            // Relative pathing allows you to describe a path to a directory or file RELATIVE to your 
            // current direcory.
            // . <- this means current direcory
            // .. <- go up a directory
            // ./dopefiles/text.txt   -> in the current current directory, traverse into a directory, then access a file
            // ../../Documents/taxform.pdf  -> go up one directory, then go up another directory, then access the documents
            // folder in that directory, then access the tax form
            var filePath = $"../../../text.txt";

            Console.WriteLine("enter a name ;)");
            var userInput = Console.ReadLine();

            AppendToFile(filePath, userInput);

            var namesFromFile = ReadFromFile(filePath);

            Console.ReadLine();
        }

        static void CreateFile(string path)
        {
            var names = new List<string>();
            names.Add("James");
            names.Add("Albert");
            names.Add("Rachel");
            names.Add("Carson");
            names.Add("Bob");


            // A stream is a "stream of data" that you're program is reading
            // in REAL TIME. ie. you are STREAMING data to your "streaming" class
            // and the "streaming object" will HANDLE getting that data for your 
            // program in real time.
            using FileStream fileStream = File.Create(path); // <- this is a stream
            // pointing to an OPEN file, the open file is the stream, READING stream,
            // im READING the open connection to the file

            using StreamWriter streamWriter = new StreamWriter(fileStream); // <- open stream
            // that allows me to write to another open stream
            // WRITING STREAM, this allows me to WRITE to that open file

            foreach (var name in names)
            {
                streamWriter.WriteLine(name);
            }
        }


        static IEnumerable<string> ReadFromFile(string path)
        {
            using var fileStream = File.Open(path, FileMode.Open);
            using var streamReader = new StreamReader(fileStream);

            var names = new List<string>();
            
            while (!streamReader.EndOfStream)
            {
                names.Add(streamReader.ReadLine());
            }

            return names;
        }


        static void AppendToFile(string path, string line)
        {
            using var fileStream = File.Open(path, FileMode.Append);
            using var streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(line);
        }
    }
}
