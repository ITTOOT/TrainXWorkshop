using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods003
{
    class Program
    {
        readonly int A = 1000;
        static void Main(string[] args)
        {
            int x, y, z;
            
            // int x = 1, y = 2;
            // Add(x, y);// by  value (ByVal) 'In'
            // int r = Add(ref x, ref y);// By referance (ByRef) 'In - Out'
            int r = Add(out x, out y, out z);// By referance (ByRef) 'Out'

        }

        // by value (ByVal) 'In'
        static int Add(int x, int y)
        {
            x = 99;
            return x + y;
        }
        // By referance (ByRef) 'In - Out'
        static int Add(ref int x, ref int y)
        {
            x = 99;
            return x + y;
        }
        // By referance (ByRef) 'Out'
        static int Add(out int x, out int y, out int z)
        {
            x = 99;
            y = 2;
            z = 3;
            return x + y + z;
        }
    }
}
