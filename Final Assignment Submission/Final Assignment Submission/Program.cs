// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;
using Final_Assignment_Submission;

namespace Final_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Muhammad" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}



