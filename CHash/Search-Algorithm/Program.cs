using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----Please Select Options-------");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Liner Search");
                Console.WriteLine("2. Binary Search");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Choice : " + choice);
                Search search = new Search();
           
             
                if (choice == 0)
                {
                    Console.WriteLine("Program End........");
                    return;
                }
                switch (choice)
                {
                    case 1:
                        search.LinearSearch();
                        break;
                    case 2:
                        search.BinarySearch();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
