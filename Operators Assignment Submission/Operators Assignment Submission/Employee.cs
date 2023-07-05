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
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            if (employeeOne.ID == employeeTwo.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            if (employeeOne.ID == employeeTwo.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
