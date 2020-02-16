using System;
using System.Collections.Generic;
using System.Text;
using codePractice.DataStructure;

namespace codePractice.Helpers
{
    public static class DataStructureHelper
    {
       
        /// <summary>
        ///  Swapping an integer type listNode
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public static void Swap( ListNode<int> A, ListNode<int>  B)
        {
            int temp;
            temp = A.val;
            A.val = B.val;
            B.val = temp;
        }

        /// <summary>
        /// Sorting a NodeList using bubble sort with complexity of O(N^2)
        /// </summary>
        /// <param name=""></param>
        public static void Sort(this ListNode<int> node)
        {
            ListNode<int> currPtr_i = node;
            ListNode<int> currPtr_j;
        
            while (currPtr_i!=null)
            {
                currPtr_j = node;
                while (currPtr_j !=null)
                {
                    if(currPtr_i.val < currPtr_j.val)
                        Swap(currPtr_i, currPtr_j);

                    currPtr_j = currPtr_j.next;
                }

                currPtr_i = currPtr_i.next;
            }
        }
    }
}
