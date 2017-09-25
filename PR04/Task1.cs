using System.Collections.Generic;
using System.IO;

namespace PR04 {
    public class Task1 {
        private string _readPath;
        private string _writePath;

        public Task1(string readPath, string writePath) {
            _readPath = readPath;
            _writePath = writePath;
        }

        public List<string> ReadAndGetQuestionsFromFile() {
            List<string> listOfQuestions = new List<string>();
            
            using (StreamReader reader = new StreamReader(_readPath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    listOfQuestions.Add(line);
                }
            }

            return listOfQuestions;
        }

        public void WriteAnswersIntoFile(List<string> answers) {
            using (StreamWriter writer = new StreamWriter(_writePath, true)) {
                writer.WriteLine("----------");
                foreach (string a in answers) {
                    writer.WriteLine(a);
                }
                writer.WriteLine("----------");
            }
        }
    }
}