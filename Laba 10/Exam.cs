using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Laba_10
{
    internal class Exam
    {
        string distipline;
        int grade;
        DateTime date_exam;
        public string Discipline
        {
            get => distipline;
            set => distipline = value;
        }

        public int Grade
        {
            get => grade;
            set => grade = value;
        }

        public DateTime DateExam
        {
            get => date_exam;
            set => date_exam = value;
        }
        public Exam(string Distipline, int Grade, DateTime Dete_exam)
        {
            distipline=Distipline;
            grade=Grade;
            date_exam=Dete_exam;
        }
        public Exam()
        {
            distipline = "Арифм.лог.";
            grade = 0;
            date_exam = new DateTime(2025, 1, 15, 8, 0, 0);
        }
        public override string ToString()
        {
            return $"{distipline}, оценка: {grade}, дата экзамена: {date_exam}";
        }
    }
}
