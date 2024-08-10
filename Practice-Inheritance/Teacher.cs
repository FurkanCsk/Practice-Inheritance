using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    // Inherits from BasePerson class
    public class Teacher : BasePerson
    {
        private double _salary;

        // Property for accessing and modifying the _salary field.
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }

        // Initialize a new instance of the Teacher class with specified values.
        public Teacher(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        // Default Constructor, initializes a new instance of the Teacher class.
        public Teacher() { }

        // Method that displays the Teacher's informations, including its DisplayInfo method and salary.
        public void DisplayTeacher()
        {
            DisplayInfo();
            Console.WriteLine($"Salary -> {Salary}\n");
        }
    }
}
