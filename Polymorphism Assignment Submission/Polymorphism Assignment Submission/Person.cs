using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    public abstract class Person // an abstract class to inherit from
    {
        public string firstName { get; set; }
                                                // Giving it 2 properties that'll be inherited from
        public string lastName { get; set; }

        public virtual void SayName() // An inheriting virtual method w/o implementation
        {
            
        }
    }
}
