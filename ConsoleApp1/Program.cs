using ClassLibrary1;
using ConsoleApp1;
using FirstConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Class1 c = new Class1();
        c.myLocalVar = "New Var";
        c.sharpen();
        Console.WriteLine(c.myLocalVar);
        Console.WriteLine(c.MakePencil(c.myLocalVar.Length));
        

        hwDay1 h1 = new hwDay1();
        h1.mathClass(4,3);
        h1.stringClass("Devansh", "Jain");
        h1.dateTime();
        

        Collections c = new Collections();
        c.add(20);
        c.add(30);
        c.add(50);
        c.print();
        */

        Class5 C1 = new Class5();
        C1.populate();
        C1.display();
    }
}