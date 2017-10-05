using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {

        public string FirstName { get; private set;  }
        public int Age { get; set; }

        public Human()
        {
            FirstName = "Bassam";
        }

        public Human(string firstName)
        {
            this.FirstName = firstName;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"I am {Age} years old");
        }

        public string NameMashup(string lastName)
        {
            string mashup = $"{FirstName} {lastName}";
            return mashup;  
        }







    }
}
