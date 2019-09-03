using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class NextPermutationInt
    {
        public void NextPermutation(int[] num)
        {
            var vioIndex = FindVioIndex(num);

            // step 2
            var rightIndex = FindRightIndex(num, ref vioIndex);
            Console.WriteLine("vioIndex " + vioIndex + "rightIndex " + rightIndex);
            // step 3
            Swap(ref num[vioIndex], ref num[rightIndex]);

            // step 4
            ReverseFromVioIndexToEnd(num, vioIndex);
        }
        private static void ReverseFromVioIndexToEnd(int[] num, int vioIndex)
        {
            vioIndex++;
            var end = num.Length - 1;
            while (end > vioIndex)
            {
                Swap(ref num[vioIndex], ref num[end]);
                end--;
                vioIndex++;
            }
        }

        private static int FindRightIndex(int[] num, ref int vioIndex)
        {
            var rightIndex = num.Length - 1;
            if (vioIndex > 0)
            {
                vioIndex--;
                while (rightIndex >= 0 && num[rightIndex] <= num[vioIndex])
                {
                    Console.WriteLine("rightIndex " + rightIndex + " value " + num[rightIndex]);
                    rightIndex--;
                }
            }
            Console.WriteLine("rightIndex " + rightIndex);
            return rightIndex;
        }
        private static int FindVioIndex(int[] num)
        {
            var vioIndex = num.Length - 1;
            while (vioIndex > 0)
            {
                if (num[vioIndex - 1] < num[vioIndex])
                {

                    Console.WriteLine("vioIndex " + vioIndex + " value " + num[vioIndex]);
                    return vioIndex;
                }
                vioIndex--;
            }
            Console.WriteLine("vioIndex " + vioIndex);
            return vioIndex;
        }

        private static void Swap(ref int a, ref int b)
        {
            var swap = a;
            a = b;
            b = swap;
        }
    }
}
