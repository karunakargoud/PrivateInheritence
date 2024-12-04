using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrivateInheritence
{
    internal class One
    {

        private int x, y;
        public One(int x, int y)
        {
            Console.WriteLine("constructors from parent class One");
            this.x = x;
            this.y = y;
        }
        public void ShowXY()
        {
            Console.WriteLine("ShowXY of  parent class One " + x + " " + y);
        }
    }
}
