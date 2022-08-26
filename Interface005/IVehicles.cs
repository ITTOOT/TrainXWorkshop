using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface005
{
    //Drivable interface
    interface IDrivable
    {      
        void Start();
        void Steer();
        void Accelerate();
        void Brake();
    }

    //Crashable interface
    interface ICrashable
    {
        void Stop();
        void Crunch();
        void Bend();
        void Smash();
    }
}
