using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap h = new Heap();
            while (true)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create Tree");
                Console.WriteLine("2. Display List");
                Console.WriteLine("3. Insert into Heap");
                Console.WriteLine("4. Delete Heap List");
                Console.WriteLine("5. Search item in heap");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Program End..");
                    break;
                }
                int item;
                switch (choice)
                {
                    case 1:
                        h.CreateSampleHeap();
                        break;
                    case 2:
                        h.DisplaySampleHeap();
                        break;
                    case 3:
                        Console.WriteLine("Please enter number : ");
                        item = Convert.ToInt32(Console.ReadLine());
                        h.InsertItem(item);
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
