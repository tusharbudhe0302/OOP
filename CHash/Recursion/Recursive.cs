using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursive
    {
        public int factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * factorial(number - 1);
        }
        public void  factorialPrintBefore(int number)
        {
            if (number == 0)
            {
                return  ;
            }
            Console.WriteLine(number + " Before ");
             factorialPrintBefore(number - 1);
        }
        public void factorialPrintAfter(int number)
        {
            if (number == 0)
            {
                return ;
            }
             factorial(number - 1);
            Console.WriteLine(number + " After ");
        }

        /*
         * LSD = n%10 To get Reminder;
         * Divisor,Coefficient,Reminder
         *  LSD = n/10 To add Reminder;
         *  if(n/10) == 0 n will have only one digit.
         */
        internal int sumOfDigits(int number)
        {
            if(number/10 == 0)
            {
                return number;
            }
            return sumOfDigits(number/10) + number%10;
        }
    }
}
