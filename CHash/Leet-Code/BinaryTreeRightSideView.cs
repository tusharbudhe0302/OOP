using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class Max_Values
    {
        public int max;
    }
    class BinaryTreeRightSideView
    {
        Max_Values maxNum = new Max_Values();
        List<int> innerList = new List<int>();
        public void PrintVirtualOrder(TreeNode root, Max_Values max, int hd)
        {
            if (root == null)
                return;
            if (hd > max.max)
            {
                innerList.Add(root.val);
            }
            PrintVirtualOrder(root.right, max, hd + 1);
            PrintVirtualOrder(root.left, max, hd - 1);
        }
        public void execute(TreeNode root)
        {
            PrintVirtualOrder(root, maxNum, 0);
        }
    }
}
