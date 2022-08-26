using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface018
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Employee > l = new List<Employee>();
            l.Add(new Employee() { FirstName = "Fred", LastName = "Name" });
            l.Add(new Employee() { FirstName = "Joe", LastName = "Blogs" });
            l.Add(new Employee() { FirstName = "Mary", LastName = "Andrews" });

            l.Sort();
        }
    }


    class Employee : IComparable<Employee> //IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Employee other)
        {    
            if (other == null)
                return 1;

            if (other != null)
                return this.LastName.CompareTo(other.LastName);
            else
                throw new ArgumentException("#1001");
            
            int switch_on = 0;
            switch (switch_on)
            {
                case 1:
                    return 1;
                case 2:
                    return this.LastName.CompareTo(other.LastName);
                default:
                    throw new ArgumentException("#1001");
            }
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj == null)
        //        return 1;

        //    Employee otherEmployee = obj as Employee;
        //    if (otherEmployee != null)
        //        return this.LastName.CompareTo(otherEmployee.LastName);
        //    else
        //        throw new ArgumentException("Object is not an Employee!");
        //}
    }
}
