using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_10
{
    internal class Student
    {
        Person person;
        Education education;
        int grup_Numb;
        Exam[] passed_exams;
        public Person Person
        {
            get => person;
            set => person = value;
        }

        public Education Education
        {
            get => education;
            set => education = value;
        }

        public int GroupNumber
        {
            get => grup_Numb;
            set => grup_Numb = value;
        }

        public Exam[] PassedExams
        {
            get => passed_exams;
            set => passed_exams = value;
        }
        public Student(Person person, Education education, int grup_numb,params Exam[] exams)
        {
            this.person = person;
            this.education = education;
            this.grup_Numb=grup_numb;
            this.passed_exams =exams;
        }
        public Student()
        {
            this.person = new Person();
            this.education=default;
            this.grup_Numb=0;
            this.passed_exams=new Exam[0];
        }
        public double AvgGrade
        {
            get
            {
                int grads = 0;
                foreach (Exam grade in passed_exams)
                {
                    grads+=grade.Grade;
                }
                return (double)grads/passed_exams.Length;
            }
        }
        public bool this[Education education]
        {
            get { return this.education == education; }
        }
        public void AddExams(params Exam[] exams)
        {
            int oldLength = passed_exams.Length;
            Exam[] newArray = new Exam[oldLength + exams.Length];
            for (int i = 0; i < oldLength; i++)
                newArray[i] = passed_exams[i];
            for (int i = 0; i < exams.Length; i++)
                newArray[oldLength + i] = exams[i];
            passed_exams = newArray;
        }
        public override string ToString()
        {
            string examsText;

            if (passed_exams != null && passed_exams.Length > 0)
            {
                examsText = "";
                foreach (var exam in passed_exams)
                {
                    examsText += "\n  - " + exam.ToString();
                }
            }
            else
            {
                examsText = "Нет данных";
            }

            return $"ФИО: {person}\nФорма обучения: {education}\nНомер группы: {grup_Numb}\nСданные экзамены:\n  - {examsText}";
        }
        public virtual string ToShortString()
        {
            return $"ФИО: {person}\nФорма обучения: {education}\nНомер группы: {grup_Numb}\nСредний балл: {AvgGrade}";
        }
    }
}
