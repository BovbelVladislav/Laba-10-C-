using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_10
{
    internal class Person
    {
         string name;
         string surname;
         DateTime birthday;
         public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int BirthYear
        {
            get
            {
                return birthday.Year;
            }
            set
            {
                birthday = new DateTime(value, birthday.Month, birthday.Day);
            }
        }

        public Person(string Name, string Surname, DateTime Birthday)
        {
            name = Name;
            surname = Surname;
            birthday = Birthday;
        }
        public Person()
        {
            name = "";
            surname = "";
            DateTime birthday = new DateTime(2007, 10, 14);
        }
        public override string ToString()
        {
            return $"{surname} {name}, дата рождения: {birthday}";
        }
        public virtual string ToShortString()
        {
            return $"{surname} {name}";
        }
    }
}
