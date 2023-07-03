using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // Prints out this string
            Console.WriteLine("What is your package weight ?"); // Prints out this string
            int packageWeight = Convert.ToInt32(Console.ReadLine()); // Stores user input into a variable

            // this if statement check if user input variable value is less than 50 or not. If it's greater
            // then the program ends here & we print out the string
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); // Prints out this string
                Console.ReadLine();
            }
            // If it's less than 50 the program ocntinues with the else statement
            else
            {
                Console.WriteLine("What's the width of your package ?"); // Prints out this string

                int packageWidth = Convert.ToInt32(Console.ReadLine()); // Stores user input into a variable

                Console.WriteLine("What's the height of your package ?"); // Prints out this string
                int packageHeight = Convert.ToInt32(Console.ReadLine()); // Stores user input into a variable

                Console.WriteLine("What's the length of your package ?"); // Prints out this string
                int packageLength = Convert.ToInt32(Console.ReadLine()); // Stores user input into a variable

                // This if statement will check if the total dimensions together is less than 50 or not
                // If it's greater, the program ends & we print the string
                if (packageHeight + packageLength + packageWidth > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); // Prints out this string
                    Console.ReadLine();
                }

                // If it's less than 50, then the program continues with this else if statement
                else if (packageHeight + packageLength + packageWidth < 50)

                {
                    int finalResults = (packageWidth * packageHeight * packageLength) * packageWeight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + finalResults + ".00"); // Prints out this string & variable
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }

            }
        }
    }
}
