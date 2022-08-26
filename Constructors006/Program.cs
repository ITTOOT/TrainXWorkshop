using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors006
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            Square s = new Square();

            Employee e = new Employee()
            {
                FirstName = "Fred",
                LastName = "Flintstone"
            }; // Object initialisers
            e.id = 100;
        }

        //Employee
        class Employee
        {
            public int id;
            public string FirstName
            {
                get;
                set;
            }
            public string LastName
            {
                get;
                set;
            }
        }

        class Shape
        {
            private string colour;
            private int side = 50;
            public Shape()
            {
                colour = "Blue";
            }
            public Shape(int side) : this()
            {
                this.side = side;
            }
        }
        class Retangle : Shape
        {
            private int width = 100;
            //Constructor
            public Retangle()
            {
                width = 200;
            }
            public Retangle(int width) : this()
            {
                this.width = width;
            }
        }
        class Square : Retangle
        {
            //Constructor
            public Square() : base(999)
            {
                int x = 3;
            }
        }
    }
}
