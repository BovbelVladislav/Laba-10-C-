using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_10
{
    enum Education{
        Specialist,
        Вachelor,
        SecondEducation
    }
    internal class Class1(int age,string name)
    {
        protected int age;
        protected string name;
        public override string ToString()
        {
            return $"что-то печатается";
        }
    }
}
