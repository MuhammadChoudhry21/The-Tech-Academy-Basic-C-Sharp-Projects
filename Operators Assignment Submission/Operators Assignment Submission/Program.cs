using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            // Instantiating 2 employee objects with property values
            Employee employee1 = new Employee() { ID = "one", firstName = "Roger", lastName = "Lum" };
            Employee employee2 = new Employee() { ID = "two", firstName = "Marie", lastName = "Hill" };

            // Trying to compare ID rpoperty of each object
            employee1 = employee1.ID == employee2.ID;
            Console.ReadLine();
        }
    }
}
