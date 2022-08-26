using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHU;

namespace Intro001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 2;
            a = 3;

            int r = a;



            Maths.Add();
            SHU.RD.Maths.Add();
            SU.Maths.Add();
        }
    }
}

//SHU
namespace SHU
{
    //RD
    namespace RD
    {
        class Maths
        {
            public static int Add() { return 2; }
        }
    }

    class Maths
    {
        public static int Add() { return 1; }
    }
}
//SU
namespace SU
{
    class Maths
    {
        public static int Add() { return 2; }
    }
}
