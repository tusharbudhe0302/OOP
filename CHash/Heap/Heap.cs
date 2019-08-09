using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Heap
    {
        int[] a;
        int n;
        public Heap()
        {
            n = 0;
            a = new int[100];
            a[0] = 9999;
        }
        public void InsertItem(int item)
        {
            n++;
            a[n] = item;
            MoveUp(n);
        }
        private void MoveUp(int i)
        {
            int k = a[i];
            int iparent = i / 2;
            while (k > a[iparent])
            {

                a[i] = a[iparent];
                a[iparent] = k;
                i = iparent;
                iparent = i / 2;
            }
            a[i] = k;
        }
        internal void CreateSampleHeap()
        {
            n++;
            a[n] = 45;
            n++;
            a[n] = 30;
            n++;
            a[n] = 35;
            n++;
            a[n] = 20;
            n++;
            a[n] = 10;
            n++;
            a[n] = 29;
            n++;
            a[n] = 32;
            Console.WriteLine("Creation Of Heap Is Done!");
            return;
        }
        internal void DisplaySampleHeap()
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != null)
                {
                    Console.Write(a[i] + " ");
                }
                else
                {
                    break;
                }
            }
        }
        internal void DeleteRoot()
        {
            a[1] = a[n];
            n--;
            MoveDownHeap(1);
        }
        void MoveDownHeap(int i)
        {
            int k = a[i];
            int left = 2 * i;
            int right = 2 * i + 1;
            while (right <= n)
            {
                if (k >= a[left] && k > a[right])
                {
                    a[i] = k;
                    return;
                }
                else if (a[left] > a[right])
                {
                    a[i] = a[left];
                    i = left;
                }
                else
                {
                    a[i] = a[right];
                    i = right;
                }
                left = 2 * i;
                right = 2 * i + 1;
            }
            /*
             * Out Of While loop. If Node is even
             */
            if (left == n && k < a[left])
            {
                a[i] = a[left];
                i = left;
            }
            a[i] = k;
        }
        /*
         * Restore Top to Bottom
         * Restore Bottom to Top
         */
        internal void HeapBinaryTree()
        {
        }
    }
}
