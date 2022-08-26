using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface005
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck t = new Truck();
            Car c = new Car();
            t.Start();
            c.Steer();

            //Caterpillar drive interface
            Caterpillar cat = new Caterpillar();
            Drive(cat);

            //Drive method impliments IDrivable interface
            Drive(t);
            
        }
        //Drive method
        static void Drive(IDrivable d)
        {
            d.Accelerate();
            d.Steer();
            d.Brake();
        }
    }

    //Vehicle abstract class - has missing information

    abstract class Vehicle
    {
        public void Start() { Console.WriteLine("Vehicle::Start"); }
        abstract public void Steer();
        abstract public void Accelerate();
        abstract public void Brake();
    }

    //Caterpillar
    class Caterpillar : IDrivable
    {
        //Dig
        public void Dig()
        {
            Console.WriteLine("Caterpillar::Dig");
        }
        //Crawl
        public void Crawl()
        {
            Console.WriteLine("Caterpillar::Crawl");
        }
        /// <summary>
        /// Explicit implimentation of interface
        /// </summary>
        void IDrivable.Start()
        {
            throw new NotImplementedException();
        }

        void IDrivable.Steer()
        {
            throw new NotImplementedException();
        }

        void IDrivable.Accelerate()
        {
            throw new NotImplementedException();
        }

        void IDrivable.Brake()
        {
            throw new NotImplementedException();
        }
    }

    //Truck
    class Truck : IDrivable
    {
        public void Start() 
        {
            Console.WriteLine("Truck::Start"); 
        }
        public void Tip()
        {
            Console.WriteLine("Truck::Tip");
        }

        void IDrivable.Accelerate()
        {
            throw new NotImplementedException();
        }

        void IDrivable.Brake()
        {
            throw new NotImplementedException();
        }

        void IDrivable.Start()
        {
            throw new NotImplementedException();
        }

        void IDrivable.Steer()
        {
            throw new NotImplementedException();
        }
    }

    //Car
    class Car : IDrivable
    {

        //Start
        public void Start()
        {
            Console.WriteLine("Car::Start");
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
        
        public void Steer()
        {
            throw new NotImplementedException();
        }
    }
}
