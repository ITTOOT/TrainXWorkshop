using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using libraries added to referances
using MathsLibrary010;

namespace Calculator011
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Maths.Add(3, 4); // Singleton pattern  - no instatiation - Static (Shared)

            DataSet ds = DataSet.CreateInstance();
            ds.DoSomething();
        }
    }

}
