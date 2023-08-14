using Bytescout.Spreadsheet;
using ClassLibrary1;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee[] E = new Employee[5];
        
        E[0] = new Employee
        {
            name = "Devansh",
            gender = "Male",
            salary = 55000.0,
            department = "SDE"
        };

        E[1] = new Employee
        {
            name = "Priya",
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
        

        //populate(5, E);
        Console.WriteLine("Enter Choice");
        Console.WriteLine("1. Search by Name");
        Console.WriteLine("2. Show by Gender");
        Console.WriteLine("3. Show by Department");
        Console.Write("Choice : ");
        int ch = int.Parse(Console.ReadLine());
        switch (ch)
        {
            case 1:
                Console.Write("\nEnter Name to be Searched: ");
                string s1 = Console.ReadLine();
                for (int i = 0; i < 5; i++)
                {
                    if (E[i].name.Equals(s1))
                    {
                        Console.WriteLine("\nEmployee Number: " + (i+1));
                        Console.WriteLine("Employee Name: " + E[i].name);
                        Console.WriteLine("Employee Gender: " + E[i].gender);
                        Console.WriteLine("Employee Salary: " + E[i].salary);
                        Console.WriteLine("Employee Department: " + E[i].department);
                    }
                }
                break;
             case 2:
                Console.Write("\nEnter Gender to be Searched: ");
                string s2 = Console.ReadLine();
                for (int i = 0; i < 5; i++)
                {
                    if (E[i].gender.Equals(s2))
                    {
                        Console.WriteLine("Employee Name: " + E[i].name);
                    }
                }
                break;
            case 3:
                Console.Write("\nEnter Department to be Searched: ");
                string s3 = Console.ReadLine();
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    if (E[i].department.Equals(s3))
                    {
                        Console.WriteLine("Employee Name: " + E[i].name);
                    }
                }
                break;
            default:
                Console.WriteLine("\nWrong Choice");
                break;
        }
    }
}