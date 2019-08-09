using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcsharp
{
    /*
     * find log to base 12
     * log(n) / log(2)
     */
    class Question4
    {
        public double ClaculateLogToBase2(int number)
        {
            Console.WriteLine("Log of number : "+ Math.Log(number));
            return Math.Log(number) / Math.Log(2);

        }
    }
}
