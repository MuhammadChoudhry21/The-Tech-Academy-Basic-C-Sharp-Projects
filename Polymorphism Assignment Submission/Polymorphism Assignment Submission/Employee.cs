using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    public class Employee : Person, IQuittable // A class inherited from 'Person' asbtract class
    {
        public override void SayName() // Overriding the inheriting method with
                                       // our own implementation
        {
            Console.WriteLine("First Name: " + firstName + " Last Name: " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("10 + 10 = 20");
        }
    }
}
