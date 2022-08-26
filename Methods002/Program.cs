using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods002
{
    class Program
    {
        static void Main()
        {
            short m = 1;
            var r = Add(1L, 2, 3);
            //Console.WriteLine("This written line");
        }


        //Method overloading
        //static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static long Add(long x, int y, int z)
        {
            return x + y + z;
        }
        //static int Add(float x, params int[] ar)
        //{
        //    int r = 0;
        //    foreach(int i in ar)
        //    {
        //        r = +i;
        //    }
        //    return r;
        //}
    }
}
