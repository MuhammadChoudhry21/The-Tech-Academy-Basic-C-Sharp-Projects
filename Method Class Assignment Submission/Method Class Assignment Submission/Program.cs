using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethods mathOp = new myMethods(); // Instantiating the class

            mathOp.math(50, 100); // Calling the method & passing 2 numbers
            mathOp.math(num2: 50, num1: 100); // specifies by parameters by name
            Console.ReadLine();
        }
    }
}
