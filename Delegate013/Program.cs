using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate013
{
    class Program
    {
        delegate void PumpStart();
        static void Main(string[] args)
        {
            PumpStart ps = new PumpStart(ElectricPumpStart); // ElectricPumpStart = publisher
            ps();  // ps = subscriber
            ps -= ElectricPumpStart; // Reomove from delegate as the parameter can not be null
            ps += DieselPumpStart;
            ps();
            int r = 0;
            if (ps != null)
                ps();

        }

        //Actions - Same layout of method
        static void DieselPumpStart()
        {
            Console.WriteLine("DieselPumpStart");
        }
        static void ElectricPumpStart()
        {
            Console.WriteLine("ElectricPumpStart");
        }
    }
}
