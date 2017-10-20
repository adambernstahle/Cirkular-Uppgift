using System;
using System.Collections.Generic;
using System.Text;

namespace Cirkulär_Buffer_Uppgift
{
    class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }
        public void Add(string newValue)
        {
            Node newNode = new Node() { Value = newValue };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }
        public void Read()
        {
            if (Count > 0)
            {

                Console.WriteLine();
            }
            else
                Console.WriteLine("No element exist in this linked list.");
        }
    }
}
