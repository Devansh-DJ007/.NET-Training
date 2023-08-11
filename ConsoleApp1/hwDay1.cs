using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class hwDay1
    {
        // Math Class
        public void mathClass(int x,int y)
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("Math.E = " + Math.E);
            Console.WriteLine("Math.PI = " + Math.PI);
            Console.WriteLine("Math.Pow = " + Math.Pow(x,3));
            Console.WriteLine("Math.Sqrt = " + Math.Sqrt(x));
            Console.WriteLine("Math.Sin = " + Math.Sin(x));
            Console.WriteLine("Math.Equals = " + Math.Equals(x,3));
            Console.WriteLine("Math.Max = " + Math.Max(x, y));
        }
        public void stringClass(String s1, String s2)
        {
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("s1 Length = " + s1.Length);
            Console.WriteLine("s2 Length = " + s2.Length);
            Console.WriteLine("String.Equals = " + String.Equals(s1,s2));
            Console.WriteLine("String.Concat = " + String.Concat(s1,s2));
            Console.WriteLine("String1.Intern = " + String.Intern(s1));
            Console.WriteLine("String2.Intern = " + String.Intern(s2));
            Console.WriteLine("s1.ToUpper = " + s1.ToUpper());
        }
    }
}
