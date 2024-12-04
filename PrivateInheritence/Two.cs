using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateInheritence
{
    internal class Two:One
    {
        int z;
        public Two(int i,int j,int k):base(i,j)
        {
            //x = i;
            //y = j;
            z = k;  
            
        }
        public void ShowXYZ()
        {
            ShowXY();
            Console.WriteLine("From class Two - From ShowXYZ "+z);
        }

    }
}
