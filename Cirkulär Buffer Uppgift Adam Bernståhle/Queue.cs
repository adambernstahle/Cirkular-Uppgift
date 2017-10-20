using System;
using System.Collections.Generic;
using System.Text;

namespace Cirkulär_Buffer_Uppgift
{
    class Queue
    {
        public int[] buf;
        private int head;
        private int tail;
        int take;
        LinkedList lnklist = new LinkedList();


        public Queue(int n)
        {
            head = 0;
            tail = 0;
            buf = new int[n];
        }

        public bool Enqueue(int put)
        {
            if (Full())
            {
                Console.WriteLine("\nBuffert is full");
                return false;
            }
            else
            {
                buf[head] = put;
                
                head = (head + 1) % buf.Length;

                lnklist.Add(Console.ReadLine());

            }
            return true;
        }

        public bool Dequeue(ref int take)
        {
            if (Empty())
            {
                Console.WriteLine("\nBuffert is empty");
                return false;
            }
            else
            {
                take = buf[tail];
                tail = (tail + 1) % buf.Length;

                lnklist.Read();

                return true;
            }
        }        

        private bool Full()
        {
            if (tail == ((head + 1) % buf.Length))
                return true;
            else
                return false;
        }
        private bool Empty()
        {
            if (head == tail)
                return true;
            else
                return false;
        }
    }
}

