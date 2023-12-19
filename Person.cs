using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Creating an abstract class called Person
    abstract class Person
    {
        // Two string properties FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void SayName();
    }
}
