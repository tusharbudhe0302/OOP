using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class smallestSubTreeDepestNode
    {
        public TreeNode subtreeWithAllDeepest(TreeNode root)
        {
            int depth = getDepth(root);
            return getNode(root, 1, depth);
        }

        private TreeNode getNode(TreeNode node, int depth, int target)
        {
            if (node == null) return null;
            if (depth == target) return node;
            TreeNode left = getNode(node.left, depth + 1, target);
            TreeNode right = getNode(node.right, depth + 1, target);
            if (left != null && right != null) return node;
            if (left == null) return right;
            return left;
        }

        private int getDepth(TreeNode node)
        {
            if (node == null) return 0;
            int left = getDepth(node.left);
            int right = getDepth(node.right);

            return 1 + Math.Max(left, right);
        }
    }
}
