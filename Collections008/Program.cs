using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Collections
using System.Collections;

namespace Collections008
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int x = 3;
            al.Add(x);
            int y = 3;
            al.Add(y);
            long w = long.MaxValue;
            al.Add(w);
            long r = (long)al[2]; // cast the element to an int

            foreach(int i in al)
            {
                r = i;
            }

            Hashtable ht = new Hashtable();
            ht.Add("A", "Andrew");
            ht.Add("F", "Fred");
            string nameOfPerson = (string)ht["F"];

            Queue FIFO = new Queue();
            FIFO.Enqueue("A");
            FIFO.Enqueue("B");
            FIFO.Enqueue("C");
            FIFO.Enqueue("D");
            string item = (string)FIFO.Dequeue();
            Console.WriteLine(item);

            Stack slots = new Stack();
            slots.Push("X");
            slots.Push("Y");
            slots.Push("Z");
            string itemPopped = (string)slots.Pop();
            Console.WriteLine(itemPopped);
        }
    }
}
