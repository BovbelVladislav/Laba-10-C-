using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_10
{
    internal class Person
    {
        string Name;
        string Surname;
        DateTime Birthday;
        public string N
        {
            get
            {
                return Name; 
            }
            set
            {
                Name = value;
            }
        }
        public string S
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        public DateTime B
        {
            get
            {
                return Birthday;
            }
            set
            {
                Birthday = value;
            }
        }
        public int BirthYear
        {
            get
            {
                return Birthday.Year;
            }
            set
            {
                Birthday = new DateTime(value, Birthday.Month, Birthday.Day);
            }
        }

        public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }
        public Person()
        {
            Name = "";
            Surname = "";
            DateTime Birthday = new DateTime(2007, 10, 14);
        }
        public override string ToString()
        {
            return $"{Surname} {Name}, дата рождения: {Birthday}";
        }
        public virtual string ToShortString()
        {
            return $"{Surname} {Name}";
        }
    }
}
