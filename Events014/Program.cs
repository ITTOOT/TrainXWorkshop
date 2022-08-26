using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events014
{
    //delegates
    delegate void SalaryChangedHandler(decimal oldSalary, decimal newSalary);
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee() { Salary = 10000M };
            e.SalaryChanged += TellHR;
            e.Salary = 11000M;
        }
        static void TellHR(decimal oldSalary, decimal newSalary)
        {
            Console.WriteLine("Salary changed!");
        }
    }
    class Employee
    {
        decimal salary;

        public event SalaryChangedHandler SalaryChanged;
        public decimal Salary
        {
            get { return this.salary; }
            set {
                    if (this.salary == value)
                        return;
                        decimal oldSalary = this.salary;
                        salary = value;
                    if (SalaryChanged != null)
                        SalaryChanged(oldSalary, salary);
                    
                 }
        }
    }
}
