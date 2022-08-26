using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary010
{
    //Singlton or component
    public static class Maths
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x + y;
        }
    }

    //There can be only one!!
    public class DataSet
    {
        public static DataSet dataSet; // Static code recorded on disk by the compiler.
        public static DataSet CreateInstance() 
        { 
            if(dataSet == null) // If data set is null run constructor and retun the result
            {
                dataSet = new DataSet();
                return dataSet;
            }
            else // If data set has data return what is already there
                return dataSet;

        }
        //Private constructor only instantiated by the class
        private DataSet()
        {
            // Get 1GB of data, eg from test module
        }
        public void DoSomething()
        {
            // 1GB Memory, eg write test results to a file and store in archive
        }
    }
}
