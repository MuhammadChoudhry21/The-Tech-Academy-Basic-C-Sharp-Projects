using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            // Instantiating an object within the Employee child class
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            // Calling the virtual method that had our own implementation
            employee.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee(); // Using polymorphism to create an
                                                   // object of type IQuittable

            // Calling the 'Quit' method
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
