using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception012
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked // Checks for an interger overflow
                {
                    int x = 1;// int.MaxValue;
                    x++;
                }

                if (true)
                {
                    // true
                }
                

                //int y = 3, z = 0;
                //int r = y / z;
            }
            catch (DivideByZeroException ex)
            {
                throw new MyException() { MyErrorNumber = 100 };
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally // "always"
            {

            }
        }
    }
    public class MyException : Exception
    {
        public int MyErrorNumber
        {
            get;
            set;
        }
    }
}
