using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree bst = new BinarySearchTree();
            while (true)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Please Enter your choice :");
                Console.WriteLine("1. Create default Binary tree");
                Console.WriteLine("2. Create int Binary tree");
                Console.WriteLine("3. Display BST");
                Console.WriteLine("4. Min Node Value");
                Console.WriteLine("5. Max Node Value");
                Console.WriteLine("6. Height Of Tree ");
                Console.WriteLine("7. Insert Into BST ");
                Console.WriteLine("8. Insert Into BST Iterator ");
                Console.WriteLine("9. Delete Item From BST ");
                Console.WriteLine("0. Quit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice == 0)
                {
                    Console.WriteLine("Program end ...");
                    return;
                }
               
                switch (Choice)
                {
                    case 1:
                        bst.CreateTree();
                        break;
                    case 2:
                        bst.createIntTree();
                        break;
                    case 3:
                        bst.DisplayTree();
                        break;
                    case 4:
                        bst.DisplayMin();
                        break;
                    case 5:
                        bst.DisplayMax();
                        break;
                    case 6:
                        int heightOfTree = bst.DisplayHeight();
                        Console.WriteLine("Height Of Tree : " + heightOfTree);
                        break;
                    case 7:
                        Console.WriteLine("Please Enter Number you would like to insert into tree");
                        int item = Convert.ToInt32(Console.ReadLine());
                        bst.InsertItem(item);
                        break;
                    case 8:
                        Console.WriteLine("Please Enter Number you would like to insert into tree");
                        int item0 = Convert.ToInt32(Console.ReadLine());
                        bst.InsertItemI(item0);
                        break;
                    case 9:
                        Console.WriteLine("Please Enter Number you would like to delete into tree");
                        int itemDelete = Convert.ToInt32(Console.ReadLine());
                        bst.DeleteItem(itemDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}
