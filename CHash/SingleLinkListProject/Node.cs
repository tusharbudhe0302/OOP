using System;

namespace LinkListProject
{
    class Node
    {
        public Node link;
        public object data;
        public Node(object i)
        {
            data = i;
            link = null;
        }
    }
}
