using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing004
{
    //Interface
    interface IRotatable
    {
        void Rotate();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s; // = new Shape(); // new fetches memory for an objet
            // s is not the object it is just storage
            //s.Draw();
            Retangle r = new Retangle();
            r.Draw();
            s = r;
            s.Draw();
            Square sq = new Square();
            sq.Draw();
            s = sq;
            s.Draw();
            sq.Colour = "Blue";
            s.Colour = "Green";
        }
    }

    //Shape
    abstract class Shape // Abstract...
    {
        private string colour;
        //Constructor
        public Shape()
        {
            this.colour = "Red";
        }
        //Setter/Getter
        public string Colour // Property method automatic set/get
        {
            get { return this.colour; } // Get
            set { switch (value.ToLower()) //Set
                {
                    case "red":
                    case "green":
                    case "blue":
                        this.colour = colour.ToLower();
                        break;
                    default:
                        this.colour = "Red";
                        // goto case "red";
                        break;
                }
            }
        }

        // virtual tell compliler it has overides
        // abstract 
        public abstract void Draw();     
    }

    //Retangle & Square // Concrete
    class Retangle : Shape, IRotatable
    {
        public override void Draw()
        {
            Console.WriteLine("Retangle::Draw()");
        }

        public void Rotate()
        {
            Console.WriteLine("Retangle::Draw()");

        }
    }
    class Square: Retangle
    {
        sealed public override void Draw()
        {
            Console.WriteLine("Square::Draw()");
        }
    }

    //Circle
    class Circle : Shape
    {
        sealed public override void Draw()
        {
            Console.WriteLine("Circle::Draw()");
        }
    }
}















































































































































































































































































































































































































































