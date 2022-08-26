using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entity Framework from NuGet - new item - data - entity data model -
// pick the tables from the wizard.
namespace EntityFramework021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 8, 9 };

            var result = numbers.OrderBy(n => numbers.Max());
            foreach (int number in result) 
            { 
                int r = number; 
            }

            Manufacturer m = new Manufacturer() { Company = "Porsche"};

            CarsEntities entities = new CarsEntities();

            //Add Porsche
            entities.Manufacturers.Add(m);
            //Add Seat
            entities.Manufacturers.Add(new Manufacturer() { Company = "Seat" });
            entities.SaveChanges(); //Remember to save changes

            string s;
            foreach(Manufacturer mn in entities.Manufacturers) // IEnumerable - LINQ
            {
                s = mn.Company;
            }

        }
    }
}
