using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create Dummy Data ");
                Console.WriteLine("2. Create Data Using Your Choice");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Bubble Cort");
                Console.WriteLine("5. Insertion Sort");
                Console.WriteLine("6. Recursive Merge Sort");
                Console.WriteLine("7. Iterative Merge Sort ");
                Console.WriteLine("8. Quick Sort ");
                Console.WriteLine("9. Binary Tree Sort ");
                Console.WriteLine("10. Heap Sort ");
                Console.WriteLine("11. Redix Sort ");
                Console.WriteLine("12. Address Calculation Sort ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Program End..");
                    return;
                }

                switch (choice)
                {
                    case 3:
                        Sort sort = new Sort();
                        sort.SelectionSort();
                        break;
                    case 6:
                        Sort recursiveMergesort = new Sort();
                        recursiveMergesort.MergeSort();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
