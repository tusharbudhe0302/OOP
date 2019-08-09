using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class NodeInt
    {
        internal int info;
        internal NodeInt left;
        internal NodeInt right;
        public NodeInt(int i)
        {
            info = i;
            left = null;
            right = null;
        }
    }
}
