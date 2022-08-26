using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda014
{
    class Program
    {
       


        //delegate void Thing();
        delegate int Transformer(int x, int y);
        static void Main(string[] args)
        {
            string s = "Something";

            // Anonymous Method
            Action t = () => { Console.WriteLine("Here! {0}", s); };
            t();
            Action a = () => { Console.WriteLine("Action!"); };
            a(); // Delegate named Action is in a built in class library

            Transformer tr = (x,y) => x + y;
            int r = tr(3,4);

            Func<int, int, int> f1 = (x, y) => x + y;
            int r1 = f1(2, 3);

            //Func<Array[], int> f2 = (bb) => { for (int i1 = 0; i1 < bb.Length; i1++) { Array i = bb[i1]; var res = i; } return res; }; 
        }
        static void M() 
        {
            Console.WriteLine("M()");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
