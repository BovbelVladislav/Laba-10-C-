using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Laba_10
{
    internal class Exam
    {
        string Distipline { get; set; }
        int Grade { get; set; }
        DateTime Date_exam { get; set; }
        public Exam(string distipline, int grade, DateTime dete_exam)
        {
            Distipline=distipline;
            Grade=grade;
            Date_exam=dete_exam;
        }
        public Exam()
        {
            Distipline = "Арифм.лог.";
            Grade = 0;
            Date_exam = new DateTime(2025, 1, 15, 8, 0, 0);
        }
        public override string ToString()
        {
            return $"${Distipline}, оценка: {Grade}, дата экзамена: {Date_exam}";
        }
    }
}
