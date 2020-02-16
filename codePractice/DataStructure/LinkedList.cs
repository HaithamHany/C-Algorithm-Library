using System;
using System.Collections.Generic;
using System.Text;

namespace codePractice.DataStructure
{
    public class LinkedList<T>
    {
        private ListNode<T> _head;
        private int _listCount;

        public int ListCount { get { return _listCount; } private set { } }
        public ListNode<T> Head { get { return _head; } private set { }}
        public LinkedList()
        {

            _head = new ListNode<T>();
        }

        public LinkedList(T value)
        {
            _head = new ListNode<T>(value);
        }

        public void Add(T data)
        {
            ListNode<T> node = new ListNode<T>(data);
            ListNode<T> currPtr = _head;

            if (_head == null)
                _head = node;

            while (currPtr.next != null)
            {
                currPtr = currPtr.next;
            }

            currPtr.next = node;
            _listCount++;
        }

        public void PrintConsole()
        {
            ListNode<T> currPtr = _head;

            while (currPtr.next != null)
            {
                currPtr = currPtr.next;
                Console.WriteLine(currPtr.val);
            }
        }
  
        //public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        //{

        //}
    }
}
