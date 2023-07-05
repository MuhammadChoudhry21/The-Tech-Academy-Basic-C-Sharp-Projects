using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    public class Employee //Creating an Employee class
    {
        // Giving it properties
        public string ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Creating == and != overload operator
        public static Employee operator== (Employee employeeOne, Employee employeeTwo)
        {
            Console.WriteLine("They are equal");
            return true;
            
        }

        public static Employee operator!= (Employee employeeOne, Employee employeeTwo)
        {
            Console.WriteLine("They are not equal");
            return false;
        }
    }
}
