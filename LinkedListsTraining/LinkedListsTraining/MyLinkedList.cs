using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }
        public ListNode Tail { get; set; }

        int counter;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = null;
            counter = 0;

        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {

            int i = 0;
            ListNode current = Head;
            while(current != null)
            {
                if(i == index)
                {
                    return current.val;
                }
                else
                {
                    i++;
                    current = current.next;
                }
            }
            return -1;
            

        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new ListNode(val, null);
                Tail = Head;
            }
            else 
            { 
               Head = new ListNode(val, Head.next);
            }
            counter++;
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            
            
            if(Tail == null)
            {
                Head = new ListNode(val, null);
                Tail = Head;
            }
            else 
            { 
                ListNode last = new ListNode(val, null);
                Tail.next = last;
                Tail = last; 
            
            }
            counter++;
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            
            ListNode current = Head;
            
            if(index == counter) {
                index--;
                ListNode newNode = new ListNode(val, current);
                current = current.next;
                index = counter;
                  
            }
            counter++;


        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            throw new NotImplementedException();

        }
    }
}
