using System;
using System.IO;

namespace PR04 {
    internal class Program {
        public static void Main(string[] args) {
            string readPath = "questions.txt";
            string writePath = "answers.txt";

            string line;
            
            Console.Write("Sisesta nimi: ");
            string name = Console.ReadLine();

            using (StreamReader reader = new StreamReader(readPath)) {
                using (StreamWriter writer = new StreamWriter(writePath, true)) {
                    writer.WriteLine("---{0}---", name);
                    while ((line = reader.ReadLine()) != null) {
                        Console.WriteLine(line);
                        writer.WriteLine(Console.ReadLine());
                    }
                }
            }
            
            /*
            //Mu oma pask
            Task1 questionnaire = new Task1(readPath, writePath);
            
            List<string> listOfQuestions = questionnaire.ReadAndGetQuestionsFromFile();
            List<string> listOfAnswers = new List<string>();
            
            Console.WriteLine(listOfQuestions[0]);
            listOfAnswers.Add(Console.ReadLine());

            Console.WriteLine(listOfQuestions[1]);
            listOfAnswers.Add(Console.ReadLine());
            
            Console.WriteLine(listOfQuestions[2]);
            listOfAnswers.Add(Console.ReadLine());
            
            Console.WriteLine("Thanks a lot!");
            questionnaire.WriteAnswersIntoFile(listOfAnswers);
            */
            
            /*
            string filePath = 
                @"D:\Desktop\text.txt"; //Has to contain text.
            string writingFilePath = 
                @"D:\Desktop\fileToWriteAt.txt"; //Can be nonexistent.
            string unsortedFilePath = 
                @"D:\Desktop\unsortedFile.txt";
            string sortedFilePath = 
                @"D:\Desktop\sortedFile.txt";
            string line;
            
            //Example 4.D
            List<string> listOfValues = new List<string>();
            using (StreamReader reader = new StreamReader(unsortedFilePath)) {
                while ((line = reader.ReadLine()) != null) {
                    listOfValues.Add(line);
                }
            }
            
            listOfValues.Sort();
            
            using (StreamWriter writer = new StreamWriter(sortedFilePath, false)) {
                foreach (string a in listOfValues) {
                    writer.WriteLine(a);
                }
            }
            
            //Reading from a file.
            using (StreamReader reader = new StreamReader(filePath)) {
                while ((line = reader.ReadLine()) != null) {
                    Console.WriteLine(line);
                    Console.WriteLine("---");
                }
            } //Reader is killed. That's why we use 'using' statements. 
              //Otherwise StreamReader will eat our memory. Sheeeiiiiiiiiiit.
            
            //Appending text to a file.
            using (StreamWriter writer = new StreamWriter(writingFilePath, true)) {
                writer.WriteLine("Sample text.");
            } //Writer is kill'd.
            
            //Overwriting.
            using (StreamWriter writer = new StreamWriter(writingFilePath, false)) {
                writer.WriteLine("Arr, ye be raided by butt pirates.");
            } //pepsi
            */
            /*TextManipulator textManipulator = new TextManipulator(unsortedFilePath);
            textManipulator.SetSortingFilePath(sortedFilePath);
            textManipulator.SortValuesInTxtFile();*/
            
            /*
            using (StreamWriter writer = new StreamWriter("sampleText.txt", false)) {
                writer.WriteLine("Where's my money, Lebowski?");
                writer.WriteLine("Maksa võlg ära.");
            }
            */
            
            /*
            TextManipulator textManipulator = new TextManipulator(filePath);
            textManipulator.ReadTextByLine();
            textManipulator.SetWritingFilePath(writingFilePath);
            
            textManipulator.AppendTextToFile("Hai my name is wat");
            textManipulator.AppendTextToFile("A suh dude");
            
            //textManipulator.AddTextToFileAndOverwrite("wanna buy some drugs?");
            
            textManipulator.SortValuesInTxtFile("badc");
            
            List<string> listOfQuestions = new List<string>();
            listOfQuestions = textManipulator.SaveTextToList();

            foreach (string a in listOfQuestions) {
                Console.WriteLine(a);
            }
            
            Console.WriteLine("There are {0} characters in the text file.", textManipulator.GetTxtFileLength());
            */
            
            /*
            string fullPath = Path.GetFullPath(filePath);
            string extension = Path.GetExtension(filePath);
            string fileName = Path.GetFileName(filePath);
            string allText = File.ReadAllText(filePath);
            
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", fullPath, extension, fileName, allText);
            */
            
            Console.ReadLine();
        }
    }
}