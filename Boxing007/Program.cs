using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing007
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            Square sq2 = (Square)Box(sq); //Legal

            Square sq3 = new Square();
            Retangle sq4 = (Square)Box(sq3); //Illegal




            //Shape s;
            //s = new Square();
            //s.M();
            //Square sq = (Square)s;
            //s.M();

        }

        static object Box(object o)
        {
            return o;
        }
    }
    class Shape
    {
        public virtual void M()
        {
            Console.WriteLine("Shape");
        }        
    }
    class Retangle : Shape
    {
        public override void M()
        {
            Console.WriteLine("Retangle");
        }
    }
    class Square : Retangle
    {
        public override void M()
        {
            Console.WriteLine("Square");
        }
    }
}
