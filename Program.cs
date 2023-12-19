using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiating an Employee object with FirstName "Laura" and LastName "Matuszak"
            Employee employee = new Employee
            {
                FirstName = "Laura",
                LastName = "Matuszak"
            };

            // Calling the SayName() method on the Employee object
            employee.SayName();

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
