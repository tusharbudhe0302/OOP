using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace oopcsharp
{
    class Program
    {
    

        static void Main()
        {
            /*Question 1*/
            #region Question1
            while (false)
            {
                Question1 q1 = new Question1();
                int[] number = new[] { 1, 3, 5, 6 };
                int valuesearch = 5;
                Console.WriteLine("O/P Taget : " + valuesearch);
                Console.WriteLine(q1.SearchInsert(number, valuesearch));

                valuesearch = 2;
                Console.WriteLine("O/P Taget : " + valuesearch);
                Console.WriteLine(q1.SearchInsert(number, valuesearch));

                valuesearch = 7;
                Console.WriteLine("O/P Taget : " + valuesearch);
                Console.WriteLine(q1.SearchInsert(number, valuesearch));

                valuesearch = 0;
                Console.WriteLine("O/P Taget : " + valuesearch);
                Console.WriteLine(q1.SearchInsert(number, valuesearch));
            }
            #endregion
            #region Question2
            while (false)
            {
                Question2 Q2 = new Question2();
                Console.WriteLine("Please Enter Number you would like to see tree ");
                int length = Convert.ToInt32(Console.ReadLine());
                IList<IList<int>> list = Q2.Generate(length);
                foreach (var a in list)
                {
                    int count = Convert.ToInt32(a.Count);
                    Console.Write("[");
                    int i = 0;
                    foreach (var j in a)
                    {
                        i++;
                        Console.Write(j);
                        if (i < count && count > 1)
                        {
                            Console.Write(",");
                        }
                    }
                    Console.Write("]");
                    Console.WriteLine();
                }
            }
            #endregion
            #region Question3
            while (false)
            {
                Question3 q3 = new Question3();
                int answer = q3.MethofF(4, 1);
                Console.WriteLine("Q 3 : " + answer);
            }
            #endregion
            #region logtobase2
            Question4 q4 = new Question4();
            Console.WriteLine("Please enter number you would like to check log to base 2 : ");
            int logCheck  = Convert.ToInt32(Console.ReadLine());
            double result =  q4.ClaculateLogToBase2(logCheck);
            Console.Write(" Log to base 2 of  : " + logCheck + " is : " + result);
            #endregion
            Console.ReadLine();
        }
    }
}
