using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_10
{
    internal class Student
    {
        Person Person { get; set; }
        Education Education { get; set; }
        int Grup_Numb { get; set; }
        Exam[] Passed_exams { get; set; }
        public Student(Person person, Education education, int grup_numb)
        {
            Person = person;
            Education = education;
            Grup_Numb=grup_numb;
        }
        public Student()
        {
            Person = new Person();
            Education=default;
            Grup_Numb=0;
        }
        public double AvgGrade
        {
            get
            {
                int grads = 0;
                foreach (Exam grade in Passed_exams)
                {
                    grads+=grade.Grade;
                }
                return (double)grads/Passed_exams.Length;
            }
        }
        public bool this[Education education]
        {
            get { return Education == education; }
        }
        public void AddExams(params Exam[] exams)
        {
            int oldLength = Passed_exams.Length;
            Exam[] newArray = new Exam[oldLength + exams.Length];
            for (int i = 0; i < oldLength; i++)
                newArray[i] = Passed_exams[i];
            for (int i = 0; i < exams.Length; i++)
                newArray[oldLength + i] = exams[i];
            Passed_exams = newArray;
        }
        public override string ToString()
        {
            string examsText;

            if (Passed_exams != null && Passed_exams.Length > 0)
            {
                examsText = "";
                foreach (var exam in Passed_exams)
                {
                    examsText += "\n  - " + exam.ToString();
                }
            }
            else
            {
                examsText = "Нет данных";
            }

            return $"ФИО: {Person}\nФорма обучения: {Education}\nНомер группы: {Grup_Numb}\nСданные экзамены:\n  - {examsText}";
        }
        public virtual string ToShortString()
        {
            return $"ФИО: {Person}\nФорма обучения: {Education}\nНомер группы: {Grup_Numb}\nСредний балл: {AvgGrade}";
        }
    }
}
