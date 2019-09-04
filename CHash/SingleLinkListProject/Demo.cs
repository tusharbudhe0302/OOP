using SingleLinkListProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProject
{
    class Demo
    {
        private static int choice;

        static void Main(string[] args)
        {

            SingleLinkList list = new SingleLinkList();
            DoubleLinkList doubleList = new DoubleLinkList();
            int item;
            bool singlelinklist = true;
            bool doublelinklist = false;
            while (singlelinklist)
            {
                Console.WriteLine();
                Console.WriteLine("----Please Select Options-------");
                Console.WriteLine("1.  Dislpay List");
                Console.WriteLine("2.  Count number of node in list");
                Console.WriteLine("3.  Search for an element");
                Console.WriteLine("4.  Insert into emplty list / Beginning of list");
                Console.WriteLine("5. Insert node at end of list");
                Console.WriteLine("6. Insert node after specified node");
                Console.WriteLine("7. Insert node before specified node");
                Console.WriteLine("8. Insert node at given k-th position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete any specific node");
                Console.WriteLine("11.Delete last node ");
                Console.WriteLine("12. Reverse of the list");
                Console.WriteLine("13. Bubble sort by exchanging the data");
                Console.WriteLine("14. Bubble sort by exchanging the link");
                Console.WriteLine("15. Merge sort");
                Console.WriteLine("16. Insert cycle");
                Console.WriteLine("17. Delete cycle");
                Console.WriteLine("18. Remove cycle");
                Console.WriteLine("19. Create list");
                Console.WriteLine("20. Reverse List Recursive");
                Console.WriteLine("21. Quit");
                Console.WriteLine("Please Enter Your Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 21)
                {
                    Console.WriteLine("Program End........");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.DisplayListCount();
                        break;
                    case 3:
                        Console.WriteLine("Please enter item you want to search into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.SearchItemIntoList(item);
                        break;
                    case 4:
                        Console.WriteLine("Please enter item you want to insert beginning of list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(item);
                        break;
                    case 5:
                        Console.WriteLine("Please enter item you want to insert end of the list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(item);
                        break;
                    case 6:
                        list.DisplayList();
                        int itemAfterNode;
                        Console.WriteLine("Please enter item you want to insert after item");
                        itemAfterNode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item you want to insert into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterNode(itemAfterNode, item);
                        break;
                    case 7:
                        list.DisplayList();
                        int itemBeforeNode;
                        Console.WriteLine("Please enter item you want to insert before item");
                        itemBeforeNode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item you want to insert into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeforeNode(itemBeforeNode, item);
                        break;
                    case 8:
                        int position;
                        Console.WriteLine("Please enter position you want to insert item.");
                        position = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item you want to insert into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(position, item);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        int deleteatposition;
                        Console.WriteLine("Please enter position you want to delete from list. Please enter 0 if you want to make list as empty.");
                        deleteatposition = Convert.ToInt32(Console.ReadLine());
                        list.DeleteOnlyNode(deleteatposition);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSortListData();
                        break;
                    case 14:
                        list.BubbleSortListAddressOrLinkExcahnge();
                        break;
                    case 15:
                        list.MergeSort();
                        break;
                    case 16:
                        list.CreateList();
                        list.CheckCyle(1);
                        break;
                    case 17:
                        list.CreateList();
                        list.CheckCyle(2);
                        break;
                    case 18:
                        list.CreateList();
                        list.CheckCyle(3);
                        break;
                    case 19:
                        list.CreateList();
                        break;
                    case 20:
                        Node root = new Node(5);
                        root.link = new Node(7);
                        root.link.link = new Node(9);
                        Node res = list.reverseListRecursive(root);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (doublelinklist)
            {
                Console.WriteLine("----Please Select Options-------");
                Console.WriteLine("Please Enter Your Choice :");
                Console.WriteLine("1. DisplayList");
                Console.WriteLine("2. CreateItemAtEnd");
                Console.WriteLine("3. CreateItemAtBeginnning");
                Console.WriteLine("4. CreateItemAtPosition");
                Console.WriteLine("5. CreateItemAftertPosition");
                Console.WriteLine("6. DeleteFirstItem");
                Console.WriteLine("7. DeleteItemOnPosition");
                Console.WriteLine("8. UpdateItemOnPosition");
                Console.WriteLine("9. DeleteItemOnPosition");
                Console.WriteLine("10. CreateList");
           
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Choice : " +choice);
                if (choice == 11)
                {
                    Console.WriteLine("Program End........");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        doubleList.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Please Enter Item");
                         item = Convert.ToInt32(Console.ReadLine());
                        doubleList.CreateItemAtEnd(item);
                        break;
                    case 3:
                        Console.WriteLine("Please Enter Item");
                        item = Convert.ToInt32(Console.ReadLine());
                        doubleList.CreateItemAtBeginnning(item);
                        break;
                    case 4:
                        doubleList.CreateItemAtPosition();
                        break;
                    case 5:
                        doubleList.CreateItemAftertPosition();
                        break;
                    //case 6:
                    //    doubleList.DeleteFirstItem();
                    //    break;
                    //case 7:
                    //    doubleList.DeleteItemOnPosition();
                    //    break;
                    //case 8:
                    //    doubleList.UpdateItemOnPosition();
                    //    break;
                    //case 9:
                    //    doubleList.DeleteItemOnPosition();
                    //    break;
                    case 10:
                        doubleList.CreateList();
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
