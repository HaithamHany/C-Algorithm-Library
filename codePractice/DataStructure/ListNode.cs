using System;
using System.Collections.Generic;
using System.Text;

namespace codePractice.DataStructure
{
    public class ListNode<T>
    {
        public T val;
        public ListNode<T> next;

        public ListNode()
        {

        }

        public ListNode(T x)
        { 
            val = x;
        }
    }
}
