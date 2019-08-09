using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithm
{
    class Search
    {
        int[] array;
        public Search()
        {
            array = new int[10];
        }
        internal void LinearSearch()
        {
            Random rndm = new Random();
            Console.WriteLine("Items in list : ");
            for (int i = 0; i < 10; i++)
            {
                int currentItem = rndm.Next(i, 100);
                Console.Write(currentItem + " ");
                array[i] = currentItem;
            }
            Console.WriteLine();
            Console.WriteLine("Please enter you want to seach");
            int itemToSearch = Convert.ToInt32(Console.ReadLine());
            MyLinearSearch(itemToSearch);
            return;

        }

        private void MyLinearSearch(int itemToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == itemToSearch)
                {
                    Console.WriteLine("Item found at Position " + (i + 1));
                    return;
                }
            }
            Console.WriteLine("No Item found");
            return;
        }
        internal void BinarySearch()
        {
            Random rndm = new Random();
            Console.WriteLine("Items in list : ");
            for (int i = 0; i < 10; i++)
            {
                int currentItem = rndm.Next(i, 100);
                Console.Write(currentItem + " ");
                array[i] = currentItem;
            }
            Console.WriteLine();
            Console.WriteLine("Please enter you want to seach");
            int itemToSearch = Convert.ToInt32(Console.ReadLine());
            MyBinarySearch(itemToSearch);
            return;
        }
        private void MyBinarySearch(int itemToSearch)
        {
            int midIndex = array.Length / 2;
            if (itemToSearch == array[midIndex])
            {
                Console.WriteLine("Item found at position " + midIndex);
                return;
            }
            if (itemToSearch < array[midIndex])
            {
                for (int i = 0; i < midIndex; i++)
                {
                    if (array[i] == itemToSearch)
                    {
                        Console.WriteLine("Item found at Position " + (i + 1));
                        return;
                    }
                }
            }
            else if (itemToSearch > array[midIndex])
            {
                for (int i = midIndex; i < array.Length; i++)
                {
                    if (array[i] == itemToSearch)
                    {
                        Console.WriteLine("Item found at Position " + (i + 1));
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("No Item found ");
                return;
            }


        }
    }
}
