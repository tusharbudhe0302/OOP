using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class BinarySearchTree
    {
        NodeChar rootchar;
        NodeInt rootInt;
        public BinarySearchTree()
        {
            rootchar = null;
            rootInt = null;
        }
        public void CreateTree()
        {
            rootchar = new NodeChar('P');
            rootchar.left = new NodeChar('A');
            rootchar.left.left = new NodeChar('S');
            rootchar.left.right = new NodeChar('E');
            rootchar.left.left.left = new NodeChar('T');
            rootchar.left.left.right = new NodeChar('Q');
            rootchar.left.right.left = new NodeChar('D');
            rootchar.right = new NodeChar('X');
            rootchar.right.left = new NodeChar('M');
            rootchar.right.right = new NodeChar('R');
            rootchar.right.right.left = new NodeChar('C');
        }
        public void createIntTree()
        {
            rootInt = new NodeInt(50);
            rootInt.left = new NodeInt(40);
            rootInt.left.left = new NodeInt(30);
            rootInt.left.right = new NodeInt(45);
            rootInt.left.left.left = new NodeInt(20);
            rootInt.left.right.left = new NodeInt(42);
            rootInt.left.right.right = new NodeInt(49);
            rootInt.right = new NodeInt(60);
            rootInt.right.right = new NodeInt(70);
            rootInt.right.right.left = new NodeInt(65);
            rootInt.right.right.right = new NodeInt(80);
            Console.WriteLine("Tree Is ready");
        }
        internal int DisplayHeight()
        {
            return Height(rootInt);
        }
        internal void DisplayMax()
        {
            Console.WriteLine("Max item is  : " + max(rootInt));
        }
        internal void DisplayMin()
        {
            Console.WriteLine("Min item is node : " + min(rootInt));
        }
        internal void InsertItem(int item)
        {
            if (rootInt == null)
            {
                Console.WriteLine("Tree empty");
                rootInt = new NodeInt(item);
                return;
            }
            NodeInt temp = new NodeInt(item);
            NodeInt p = Insert(rootInt, item);

        }
        internal void InsertItemI(int x)
        {
            NodeInt p = rootInt;
            NodeInt Par = null;
            while (p != null)
            {
                Par = p;
                if (x < p.info)
                {
                    p = p.left;
                }
                else if (x > p.info)
                {
                    p = p.right;
                }
                else
                {
                    return;
                }
            }
            NodeInt temp = new NodeInt(x);
            if (Par == null)
            {
                rootInt = temp;
            }
            else if (x < Par.info)
            {
                Par.left = temp;
            }
            else
            {
                Par.right = temp;
            }
        }
        internal void DeleteItem(int itemDelete)
        {
            DelelteItemI(rootInt, itemDelete);
        }
        void DelelteItemI(NodeInt P, int x)
        {
            /*
             * Deletion of item from BST has 3 cases .
             * P -> Presnet Node
             * Par -> Parent Node
             * Ch -> Chlid 
             * PS -> InOrder Successor
             * S -> Sucessor
             * Case A : If leaf node. No left and right child
             * Par.left OR Parent.Right = null
             * Case B : Only one chlid Either left or right
             * Par =P; 
             * Case C : Both Child exist.  
             */
            NodeInt par;
            par = null;
            while (P != null)
            {
                par = P;
                if (x < P.info)
                {
                    P = P.left;
                }
                else if (x > P.info)
                {
                    P = P.right;
                }
                else if (x == P.info)
                {
                    break;
                }
            }
            if (P == null)
            {
                Console.WriteLine("Item not exist in the tree!");
                return;
            }
            /*
             * Case C : if Both Right & Left Presnet. Check InOrder Successor Of Node P
             */
            NodeInt PS, s;
            if (P.left != null && P.right != null)
            {
                /* Find InOrderSuccessor of Node P as  'S'
                 *   Find Parent Of InOrderSuccessor of as 'PS'
                 */
                PS = P;
                s = P.right;
                while (s.left != null)
                {
                    PS = s;
                    s = s.left;
                }
                P.info = s.info;
                par = PS;
                P = s;
            }
            /* Check Case B & Case A
             * Case B : If P has Only One Chlid i.e. Right/ Left
             * Case A :If P jhs no child. P.Right & P.left both are null
             */
            NodeInt Ch;
            if (P.left != null)
            {
                Ch = P.left;
            }
            else
            {
                Ch = P.right;
            }
            /* 
             * This code will do actual assignment of Child.
             */
            if (par == null)
            {
                rootInt = Ch;
            }
            else if (par.left == P)
            {
                par.left = Ch;
            }
            else
            {
                par.right = Ch;
            }
            Console.WriteLine("Deletion Is  Sucessfull");
        }
        NodeInt Insert(NodeInt p, int item)
        {
            if (p == null)
            {
                p = new NodeInt(item);
            }
            else if (item < p.info)
            {
                p.left = Insert(p.left, item);
            }
            else if (item > p.info)
            {
                p.right = Insert(p.right, item);
            }
            else if (p.info == item)
            {
                Console.WriteLine("Duplicate Item");

            }
            return p;
        }
        int max(NodeInt p)
        {
            while (p.right != null)
            {
                p = p.right;
            }
            return p.info;
        }
        int min(NodeInt p)
        {
            while (p.left != null)
            {
                p = p.left;
            }
            return p.info;
        }
        int Height(NodeInt p)
        {
            if (p == null)
            {
                return 0;
            }
            int HL = Height(p.left);
            int HR = Height(p.right);
            if (HL > HR)
                return 1 + HL;
            else
                return 1 + HR;
        }
        public void DisplayTree()
        {
            if (rootInt == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            Console.WriteLine("Display PreOrder Of Tree : ");
            diplayTreeDisplayPreOrderR(rootInt);
            Console.WriteLine();
            Console.WriteLine("Display InOrder Of Tree : ");
            diplayTreeDisplayInOrderR(rootInt);
            Console.WriteLine();
            Console.WriteLine("Display PostOrder Of Tree : ");
            diplayTreeDisplayPostOrderR(rootInt);
            Console.WriteLine();
            Console.WriteLine("Display LevelOrder Of Tree : ");
            diplayTreeDisplayLevelOrderR(rootInt);
            Console.WriteLine();
        }
        static void diplayTreeDisplayLevelOrderR(NodeInt root)
        {
            // Base Case  
            if (root == null)
                return;

            // Create an empty queue for level  
            // order tarversal  
            Queue<NodeInt> q = new Queue<NodeInt>();

            // Enqueue Root and initialize height  
            q.Enqueue(root);

            while (true)
            {

                // nodeCount (queue size) indicates  
                // number of nodes at current level.  
                int nodeCount = q.Count;
                if (nodeCount == 0)
                    break;

                // Dequeue all nodes of current level  
                // and Enqueue all nodes of next level  
                while (nodeCount > 0)
                {
                    NodeInt node = q.Peek();
                    Console.Write(node.info + " ");
                    q.Dequeue();
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                    nodeCount--;
                }
                Console.WriteLine();
            }
        }
        /*
     * Pre Order Of BST*
     * NLR
     */
        void diplayTreeDisplayPostOrderR(NodeInt p)
        {
            if (p == null)
            {
                return;
            }
            diplayTreeDisplayPostOrderR(p.left);
            diplayTreeDisplayPostOrderR(p.right);
            Console.Write(p.info + " ");
        }
        /*
         * Pre Order Of BST*
         * LRN
         * */
        void diplayTreeDisplayPreOrderR(NodeInt p)
        {
            if (p == null)
            {
                return;
            }
            Console.Write(p.info + " ");
            diplayTreeDisplayPreOrderR(p.left);
            diplayTreeDisplayPreOrderR(p.right);
        }
        public virtual void iterativePreorder(NodeInt NodeInt)
        {

            // Base Case  
            if (NodeInt == null)
            {
                return;
            }

            // Create an empty stack and push root to it  
            Stack<NodeInt> nodeStack = new Stack<NodeInt>();
            nodeStack.Push(NodeInt);

            /* Pop all items one by one. Do following 
               for every popped item  
            a) print it  
            b) push its right child  
            c) push its left child  
            Note that right child is pushed first so  
            that left is processed first */
            while (nodeStack.Count > 0)
            {

                // Pop the top item from stack and print it  
                NodeInt mynode = nodeStack.Peek();
                Console.Write(mynode.info + " ");
                nodeStack.Pop();

                // Push right and left children of 
                // the popped node to stack  
                if (mynode.right != null)
                {
                    nodeStack.Push(mynode.right);
                }
                if (mynode.left != null)
                {
                    nodeStack.Push(mynode.left);
                }
            }
        }
        /*
        * Pre InOrder Of BST*
        * LNR
        */
        void diplayTreeDisplayInOrderR(NodeInt p)
        {
            if (p == null)
            {
                return;
            }
            diplayTreeDisplayInOrderR(p.left);
            Console.Write(p.info + " ");
            diplayTreeDisplayInOrderR(p.right);
        }
        public virtual void inorderIterative()
        {
            if (rootInt == null)
            {
                return;
            }


            Stack<NodeInt> s = new Stack<NodeInt>();
            NodeInt curr = rootInt;

            // traverse the tree  
            while (curr != null || s.Count > 0)
            {

                /* Reach the left most Node of the  
                curr Node */
                while (curr != null)
                {
                    /* place pointer to a tree node on  
                       the stack before traversing  
                      the node's left subtree */
                    s.Push(curr);
                    curr = curr.left;
                }

                /* Current must be NULL at this point */
                curr = s.Pop();

                Console.Write(curr.info + " ");

                /* we have visited the node and its  
                   left subtree.  Now, it's right  
                   subtree's turn */
                curr = curr.right;
            }

        }

    }
}