using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment2
{
    internal class Class1
    {
        public void populate(int n, Employee[] E)
        {
            E[0] = new Employee
            {
                name = "Devansh",
                gender = "Male",
                salary = 55000.0,
                department = "SDE"
            };

            E[1] = new Employee
            {
                name = "Priyanka",
                gender = "Female",
                salary = 60000.0,
                department = "DS"
            };

            E[2] = new Employee
            {
                name = "Tanmay",
                gender = "Male",
                salary = 62000.0,
                department = "SDE"
            };

            E[3] = new Employee
            {
                name = "Pranav",
                gender = "Male",
                salary = 62000.0,
                department = "SDE"
            };

            E[4] = new Employee
            {
                name = "Jayam",
                gender = "Male",
                salary = 62000.0,
                department = "DS"
            };

        }
        
    }
}
