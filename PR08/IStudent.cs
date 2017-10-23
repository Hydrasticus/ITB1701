namespace PR08 {
    interface IStudent {
        void AddCredits(int credits);
        void AddGrade(int grade);
        void ConvertGrade(int percentage);
        void PrintAllGrades();
        void PrintInfo();
        void PrintLastGrade();
    }
}