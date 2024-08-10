using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    public class BasePerson
    {
        // Properties for accessing and modifying the field.
        public string Name { get; set; }
        public string Surname { get; set; }

        // Method that displays the Person's information. including name and surname
        public void DisplayInfo()
        {
            Console.WriteLine($"Name -> {Name}\nSurname -> {Surname}");
        }
    }
}
