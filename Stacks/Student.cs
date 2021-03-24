using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class Student
    {
        private string name;
        private string grade;


        public Student(string n, string g)
        {
            name = n;
            grade = g;
        }

        public void Display()
        {
            Console.WriteLine(name + " , " + grade);
        }

        public string GetName()
        {
            return name;
        }
    }
}
