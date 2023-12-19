using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Creating a derived class Employee from the Person class
    class Employee : Person
    {
        public int Id { get; set; }
        // Implementing the SayName method from the abstract class
        public override void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }
    }

}
