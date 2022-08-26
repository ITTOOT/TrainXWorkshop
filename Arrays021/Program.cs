using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays021
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] ar = new Employee[16];

            int[,] iar = {  
                { 10, 20, 30, 40, 50, 60 }, 
                { 100, 200, 300, 400, 500, 600 } 
            };

            int r = iar.Length;
            r = iar.GetLength(0);

            Array.Sort(iar);

            Zoo z = new Zoo();
            string a = z[1]; // Uses the indexer to return the value of the element specified.
        }
    }
    class Employee
    {
        public string FN { get; set; }
        public string LN { get; set; }
    }
    class Zoo
    {
        private string[] animals = {"Lion", "Tiger", "Bear"};

        public string this[int i] // Indexer
        {
            get { return animals[i]; }
        }
    }
}
