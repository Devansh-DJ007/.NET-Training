namespace ClassLibrary1
{
    public class Class5
    {
        Employee[] E = new Employee[3];

        public void populate()
        {
            for (int i=0; i < 3; i++)
            {
                Console.WriteLine("Enter details of employee " + i+1);
                E[i].name = Console.ReadLine();
                E[i].gender = Console.ReadLine();
                E[i].salary = Convert.ToDouble(Console.ReadLine());
                E[i].department = Console.ReadLine();
            }
        }

        public void display()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name = " + E[i].name);
                Console.WriteLine("Gender = " + E[i].gender);
                Console.WriteLine("Salary = " + E[i].salary);
                Console.WriteLine("Department = " + E[i].department);
            }
        }
    }
}