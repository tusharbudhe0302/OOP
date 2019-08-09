using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter Choice");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Two Sum");
                Console.WriteLine("2. Two Array Mutiplication");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Program Ends..");
                    return;
                }
                solution sln = new solution();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter maximum number to genrate array ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arrayInPut = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine("Please enter Number ");
                            int inputNumber = Convert.ToInt32(Console.ReadLine());
                            arrayInPut[i] = inputNumber;
                        }
                        Console.WriteLine("Please enter target ");
                        int inputTarget = Convert.ToInt32(Console.ReadLine());
                        int[] result = sln.TwoSum(arrayInPut, inputTarget);
                        break;
                    case 2:
                        int[,] array1 = new int[,]
                        {
                            {1,2,3 },
                            {1,2,3 },
                            {1,2,3 }
                       };
                        int[,] array2 = new int[,]
                       {
                            {1},
                            {1},
                           {1}

                      };
                      sln.AddTwoArray(array1, array2);
                        break;
                    default:
                        Console.WriteLine("Invali Choice");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
