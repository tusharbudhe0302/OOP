using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkListProject
{
    class DoubleLinkList
    {
        DoubleNode start, p;
        public DoubleLinkList()
        {
            start = null;
        }
        internal void DisplayList()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            p = start;
            Console.WriteLine("Your item in list");
            while (p.next != null)
            {
                PrintList(Convert.ToInt32(p.data));
                p = p.next;
            }
            Console.WriteLine();
        }
        private static void PrintList(int s)
        {
            Console.Write(s + " ");
        }
        internal void CreateItemAtBeginnning(int item)
        {
            DoubleNode temp = new DoubleNode(item);
            if (start == null)
            {
                start = temp;
                return;
            }
    
            temp.next = start;
            start.prev = temp;
            start = temp;

            return;
        }

        internal void CreateItemAtEnd(int item)
        {
            DoubleNode temp = new DoubleNode(item);
             if(start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while(p.next != null)
            {
                p = p.next;
            }
            p.next = temp;
            temp.prev = p;
        }

        internal void CreateItemAtPosition()
        {
            throw new NotImplementedException();
        }

        internal void CreateItemAftertPosition()
        {
            throw new NotImplementedException();
        }

        internal void CreateList()
        {
            Console.WriteLine("Please enter count fo list");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<count; i++)
            {
                Console.WriteLine("Please enter item ");
                int item = Convert.ToInt32(Console.ReadLine());
                CreateItemAtEnd(item);
            }
        }
    }
}
