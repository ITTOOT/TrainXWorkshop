using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Generics allows the use of the List<>
using System.Collections.Generic;

namespace Generics009
{
    class Program
    {
        static void Main(string[] args)
        {
            // The general form, i.e. not specific. In C#, generic means not specific to a particular data type.
            // TypeName<T> where T is a type parameter.
            List<Employee> l = new List<Employee>();
            l.Add(new Employee() { FirstName = "Fred", LastName = "Bloggs" });
            l.Add(new Employee() { FirstName = "Jack", LastName = "Sparrow" });

            Employee e = l[0]; // No cast required for generics

            l.Sort();
            l.Count();
        }
    }

    //
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    // Example: Define Generic Class
    class DataStore<T>
    {
        public T Data { get; set; }
    }
    // Example: Generic Class with Multiple Type Parameters
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    //// create an instance of generic classes by specifying an actual type in angle brackets.
    //// The following creates an instance of the generic class DataStore.
    //
    // DataStore<string> store = new DataStore<string>();
    //
    // class DataStore<T>
    // {
    //    public T Data { get; set; }
    // }
    //// Above, we specified the string type in the angle brackets while creating an instance. 
    //// So, T will be replaced with a string type wherever T is used in the entire class at compile-time. 
    //// Therefore, the type of Data property would be a string.
    ///
    // Declare Generic Constraints
    class DataStore02<T> where T : class
    {
        public T Data { get; set; }
    }
    // Above, we applied the class constraint, which means only a reference type can be passed as an argument
    // while creating the DataStore class object. 
}
