using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    public class Student : BasePerson
    {
        // Property for accessing and modifying the field.
        public int StudentNo { get; set; }

        // Initialize a new instance of the Student class with specified values.
        public Student(string name, string surname, int studentNo)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
        }

        // Default Constructor, initializes a new instance of the Student class.
        public Student() { }

        // Method that displays the Student's information, including DisplayInfo method and student number.
        public void DisplayStudent()
        {
            DisplayInfo();
            Console.WriteLine($"Student No -> {StudentNo}\n");
        }
    }
}
