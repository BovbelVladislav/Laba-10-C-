using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
enum Education
{
    Specialist,
    Вachelor,
    SecondEducation
}
namespace Laba_10
{
    static class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.ToShortString());
            Console.WriteLine($"Specialist: {student[Education.Specialist]}");
            Console.WriteLine($"Bachelor: {student[Education.Вachelor]}");
            Console.WriteLine($"SecondEducation: {student[Education.SecondEducation]}");
            student.Person = new Person("Пеопле", "Сурнаме", new DateTime(1989, 10, 01));
            student.Education = Education.Specialist;
            student.GroupNumber = 1;
            student.PassedExams = new Exam[]
            {
                new Exam("Математика", 5, DateTime.Now),
                new Exam("Физика", 4, DateTime.Now)
            };
            Console.WriteLine(student.ToString());
            student.AddExams(new Exam[] {
                new Exam("КПЯП",100,DateTime.Now.AddMonths(-3)),
                new Exam("ПСС",70,DateTime.Now.AddMonths(-2)),
                new Exam("JS",0,DateTime.Now.AddMonths(-1))
            });
            Console.WriteLine(student.ToString());
            const int rows = 1000;
            const int cols = 1000;
            const int total = rows * cols;
            Exam[] oneDim = new Exam[total];
            for (int i = 0; i < total; i++)
                oneDim[i] = new Exam("Math", 5, DateTime.Now);
            Exam[,] twoDimRect = new Exam[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    twoDimRect[i, j] = new Exam("Math", 5, DateTime.Now);
            Exam[][] twoDimJagged = new Exam[rows][];
            for (int i = 0; i < rows; i++)
            {
                twoDimJagged[i] = new Exam[cols];
                for (int j = 0; j < cols; j++)
                    twoDimJagged[i][j] = new Exam("Math", 5, DateTime.Now);
            }
        }
    }
}
