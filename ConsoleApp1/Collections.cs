using FirstConsole;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Collections
    {
        ArrayList A = new ArrayList();
        public void add(int x)
        {
            A.Add(x);
        }
        public void print()
        {
            for(int i=0;i<A.Count;i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }

}
