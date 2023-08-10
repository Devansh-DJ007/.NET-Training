using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    internal class Class1
    {
        public string? myLocalVar;
        public void sharpen()
        {
            if(myLocalVar != null)
            {
                myLocalVar = "Devansh";
            }
        }

        public bool MakePencil(int l1)
        {
            if (l1 > 10)
                return true;
            else
                return false;
        }


        public bool checkDateTime()
        {
            DateTime dt = new DateTime(2023,8,10);
            if (dt.Day >= 10)
                return true;
            else
                return false;
        }
    }
}
