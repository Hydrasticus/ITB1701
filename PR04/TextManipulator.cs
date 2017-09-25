using System;
using System.Collections.Generic;
using System.IO;

namespace PR04 {
    public class TextManipulator {
        private string _fileUrl;
        private string ReadingFilePath;
        private string WritingFilePath;
        private string SortingFilePath;

        //This is a constructor.
        public TextManipulator(string filePath) {
            ReadingFilePath = filePath;
        }

        public void SetWritingFilePath(string filePath) {
            WritingFilePath = filePath;
        }

        public void SetSortingFilePath(string filePath) {
            SortingFilePath = filePath;
        }
        
        //Method to overwrite text in a file.
        public void AddTextToFileAndOverwrite(string textToAdd) {
            using (StreamWriter writer = new StreamWriter(WritingFilePath, false)) {
                writer.WriteLine(textToAdd);
            }
        }
        
        //Method to add text to a file.
        public void AppendTextToFile(string textToAdd) {
            using (StreamWriter writer = new StreamWriter(WritingFilePath, true)) {
                writer.WriteLine(textToAdd);
            }
        }
        
        //Oma pask
        public void AppendTextToSortedFile(string textToAdd) {
            using (StreamWriter writer = new StreamWriter(SortingFilePath, false)) {
                writer.Write(textToAdd);
            }
        }
        
        public void SortValuesInTxtFile() {
            List<string> sortedValues = new List<string>();
            string sortedString = "";
            using (StreamReader reader = new StreamReader(ReadingFilePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    sortedValues.Add(line + " ");
                }
            }
            
            sortedValues.Sort();

            foreach (string a in sortedValues) {
                sortedString += a + "\n";
            }
            
            AppendTextToSortedFile(sortedString);
        }
        
        public string PrintOutAllTextFromFile(string fileLocation) {
            _fileUrl = fileLocation;
            string allText = File.ReadAllText(_fileUrl);

            return allText;
        }
        
        //This method reads text and prints it out.
        public void ReadTextByLine() {
            string line;

            using (StreamReader reader = new StreamReader(ReadingFilePath)) {
                while ((line = reader.ReadLine()) != null) {
                    Console.WriteLine(line);
                    Console.WriteLine("---");
                }
            }
        }

        public List<string> SaveTextToList() {
            List<string> questionsFromFile = new List<string>();
            string line;

            using (StreamReader reader = new StreamReader(ReadingFilePath)) {
                while ((line = reader.ReadLine()) != null) {
                    questionsFromFile.Add(line);
                }
            }

            return questionsFromFile;
        }

        public int GetTxtFileLength() {
            int count = 0;

            using (var sr = new StreamReader(ReadingFilePath)) {
                while (sr.Read() != -1) {
                    count++;
                }
            }
            
            return count;
        }
    }
}