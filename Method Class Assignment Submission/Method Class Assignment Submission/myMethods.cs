using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    public class myMethods
    {
        // Creating a void method with 2 integer parameters
        public void math(int num1, int num2)
        {
            int num1Result = num1 + 20; // Performing a math operation on the first parameter
            Console.WriteLine(num1Result); // Printing out the result
            Console.WriteLine(num2); // Printing out the second parameter
            Console.WriteLine("The parameters are num1 & num2"); // Specifying the parameters by name
        }
    }
}
