using System;
using System.Collections.Generic;
using System.Text;

namespace codePractice.DataStructure
{
    public static class DataStructureHelper
    {
        /// <summary>
        /// Uses bubble sort to sort a linked list with complexity of O(N^2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"> list of listnodes </param>
        public static void Sort(this LinkedList<int> list)
        {
            ListNode<int> currNode_i = list.Head;
            ListNode<int> currNode_j = list.Head;

            while (currNode_i.next != null)
            {
                while (currNode_j.next != null)
                {
                    if(currNode_i.val > currNode_j.val)
                    {
                        Swap( currNode_i,  currNode_j);
                    }

                    currNode_j = currNode_j.next;
                }

                currNode_i = currNode_i.next;
            }
        }

        private static void Swap( ListNode<int> A, ListNode<int>  B)
        {
            ListNode<int> temp;
            temp = A;
            A = B;
            B = temp;
        }
    }
}
