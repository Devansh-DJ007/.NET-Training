internal class Program
{
    private static void Main(string[] args)
    {
        int n1,n2,n3;
        Console.WriteLine("Enter 3 numbers to be added");
        String s1 = Console.ReadLine();
        String s2 = Console.ReadLine();
        String s3 = Console.ReadLine();

        try
        {
            n1 = int.Parse(s1);
            n2 = int.Parse(s2);
            n3 = int.Parse(s3);
            Console.WriteLine("\nEnter Choice");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtration");
            Console.WriteLine("3. Multiplication");
            Console.Write("Choice : ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    int sum = n1 + n2 + n3;
                    Console.WriteLine("\nSum = " + sum);
                    break;
                case 2:
                    int diff = n1 - n2 - n3;
                    Console.WriteLine("\nDifferance = " + diff);
                    break;
                case 3:
                    int mul = n1 + n2 + n3;
                    Console.WriteLine("\nMultiplication = " + mul);
                    break;
                default:
                    Console.WriteLine("\nWrong Choice");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
}