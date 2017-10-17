using System;

namespace Cirkulär_Buffer_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(5);
            while (true)
            {
                char userInput;

                Console.WriteLine("Vill du skriva (i)n eller (h)ämta?");
                userInput = Console.ReadKey().KeyChar;
                if (userInput == 'i')
                {

                    q.Enqueue();
                    Console.WriteLine();
                }
                else if (userInput == 'h')
                {
                    q.Dequeue();
                }
                else
                    Console.WriteLine("Välj i eller h");


            }
        }
    }
    class Queue
    {
        public int[] buf;
        private int head;
        private int tail;

        public Queue(int n)
        {
            head = 0;
            tail = 0;
            buf = new int[n];
        }

        public void Enqueue()
        {
            head++;
            if (head >= buf.Length)
                head = 0;
            if (Full())
            {
                Console.WriteLine("Buffer är full");
                head--;
            }
            else
            {
                bool trueFalse = false;

                while (!trueFalse)
                {
                    Console.Write("\nVad vill du skriva in? ");
                    trueFalse = int.TryParse(Console.ReadLine(), out int value);
                    buf[head] = value;
                }

            }
        }

        public void Dequeue()
        {

            tail++;
            if (tail >= buf.Length)
                tail = 0;

            if (Empty())
            {
                Console.WriteLine("\nBuffer är tom!");
                tail--;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine(buf[tail]);
                buf[tail] = 0; // TODO Reset value, look up NULL

            }
        }


        private bool Full()
        {
            if (tail == (head % buf.Length))
                return true;
            else
                return false;
        }
        private bool Empty()
        {
            if (head == (tail % buf.Length))
                return true;
            else
                return false;
        }
    }
}

