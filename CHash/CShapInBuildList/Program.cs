using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapInBuildList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(15);
            intList.Add(97);
            intList.Add(10);
            Console.WriteLine("Un Sorrted List");
            displayList(intList);
            Console.WriteLine("Binary Search Item : 45" + intList.BinarySearch(45));
            Console.ReadLine();
        }
        public static void displayList( List<int> intList)
        {
            foreach (var iList in intList)
            {
                Console.Write(iList + " ");
            }
        }
    }
}
