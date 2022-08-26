using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection020
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Square sq = new Square())
            {
                sq.Draw();
            } // sq.Dispose() is called here automatically

            int r = 3;
        }
        
    }
    class Shape : IDisposable
    {
        protected bool IsDisposing;
        public Shape()
        {
            IsDisposing = false;
            // FileInfo.... File A
        }

        public virtual void Dispose()
        {
            // Close File A

        }
    }
    class Retangle : Shape, IDisposable
    {
        public Retangle()
        {
            // SQL... connection
        }

        public virtual void Dispose()
        {
            // Close SQL
            base.Dispose();
        }
    }
    class Square : Retangle, IDisposable
    {
        public Square()
        {
            // FileInfo.... File B
        }
        ~Square() // Destructor - Calls Finalize
        {
            // Close File B ???? Programmer may have already closed File B!
            if (!IsDisposing)
                Dispose();
        }
        public override void Dispose() // Programmer calls
        {
            if (!IsDisposing)
            {
                GC.SuppressFinalize(this);
                IsDisposing = true;
                // Close File B
                base.Dispose();
            }           
        }
        public void Draw()
        {
            if (IsDisposing)
                throw new Exception();
        }
    }
}
