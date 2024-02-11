using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesStructsSpacenamesApp
{
    class Employee
    {
        public string name;
        public int age;

        public Employee() : this("Anonim", 1) {}

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }
    }

    struct BirthDate
    {
        public int day = 20;
        public int month;
        public int year;

        public BirthDate() { }

        public void Show()
        {
            Console.WriteLine($"Date: {day}.{month}.{year}");
        }
    }
}
