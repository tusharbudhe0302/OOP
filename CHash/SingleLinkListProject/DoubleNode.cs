using System;

namespace SingleLinkListProject
{
    class DoubleNode
    {
        public DoubleNode prev;
        public DoubleNode next;
        public object data;
        public DoubleNode(object i)
        {
            data = i;
            prev = null;
            next = null;
        }
    }
}
