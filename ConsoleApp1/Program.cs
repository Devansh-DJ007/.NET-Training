using FirstConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1 c = new Class1();
        c.myLocalVar = "New Var";
        c.sharpen();
        Console.WriteLine(c.myLocalVar);
        Console.WriteLine(c.MakePencil(c.myLocalVar.Length));
    }
}