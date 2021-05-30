using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example_1
{
    class Program
    {

        static void Main()
        {
            //File Methods
            
            //WriteAllText(string path, string contents) creates a new file and writes content to that file.If the target file already exists, it will overwrite it:
            string path = @".\test.txt";
            string content = "Example content as a string message";
            File.WriteAllText(path, content);
            
            //WriteAllLines(string path, string[] contents) creates a new file and writes a specified string array, then it closes the file:
            path = @".\WriteAllLines.txt";
            string[] contentArray = new string[3] { "Example content as a string message", "Another string text", "The last string" };
            File.WriteAllLines(path, contentArray);
            
            //ReadAllText(string path) opens the file in the specified path, reads all the lines as a string, and then closes the file:
            path = @".\WriteAllLines.txt";
            string readAllText = File.ReadAllText(path);
            Console.WriteLine(readAllText);
            
            //ReadAllLines(string path) opens a text file, reads all lines of the file as a string array, and then closes the file:
            path = @".\WriteAllLines.txt";
            string[] readAllLines = File.ReadAllLines(path);
            foreach (string line in readAllLines)
            {
                Console.WriteLine(line);
            }
            
            //Delete(string path) Deletes the specified file:
            path = @".\test.txt";
            //File.Delete(path);
            
            //Move(string sourceFileName, string destFileName) moves a specified file to a new location:
            path = @".\test.txt";
            string moveToPath = @".\MovedFile.txt";
            if (File.Exists(moveToPath)) //if the file on the target location exists, we need to remove it first.
            {
                File.Delete(moveToPath);
            }
            File.Move(path, moveToPath);

            //AppendAllText(string path, string contents) opens a file, appends the content to the file, and then closes the file. If a file doesn’t exist, it will create a file, write the content, and close the file.This method is useful if we want to append new content without overriding the previous one:
            path = @".\test.txt";
            content = "Append this content as a string message" + Environment.NewLine;
            File.AppendAllText(path, content);
            
            //AppendAllLines(string path, IEnumerable<string> contents) appends lines to the file and then closes the file:
            path = @".\test.txt";
            string[] _content = new string[2] { "Append this content as a string message", "Another text line" };
            File.AppendAllLines(path, _content);
            
            
            //Directory Methods

            //CreateDirectory(string path) creates directories and subdirectories on the specified location unless they already exist. It returns a DirectoryInfo object for the existing directory:
            path = @".\DirectoryExample\SubDir1\SubDir2";
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine($"Full name: {di.FullName}, Name: {di.Name}, Parent: {di.Parent} ...");
            //Delete(string path) deletes an empty directory from a specified path:
            path = @".\DirectoryExample\SubDir1\SubDir2";
            Directory.Delete(path);
            
            //Delete(string path, bool recursive) deletes the specified directory, and if it is stated, all the subdirectories and files in that directory:
            path = @".\MoveDirectory";
            try
            {
                Directory.Delete(path, true);
            }
            catch
            { }

            //Move(string sourceDirName, string destDirName) moves a file or directory and its contents to a new location:
            path = @".\DirectoryExample";
            string moveTo = @".\MoveDirectory";
            Directory.Move(path, moveTo);
        }
    }
}
