using System;
using System.IO;

namespace FilesExample{
    class Program{
        static void Main(string[] args){
            string filePath = "example.txt";
            File.WriteAllText(filePath, "hello world!");

            string readText = File.ReadAllText(filePath);  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }
    }
}