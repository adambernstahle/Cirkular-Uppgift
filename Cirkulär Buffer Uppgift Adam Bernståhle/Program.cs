using System;

namespace Cirkulär_Buffer_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(15);
            while (true)
            {
                char userInput;

                Console.WriteLine("\nVill du skriva (i)n eller (h)ämta?");
                userInput = Console.ReadKey().KeyChar;

                if (userInput == 'i')
                {
                    int inputValue;
                    Console.WriteLine("\nWrite a number");
                    while (!(int.TryParse(Console.ReadLine(), out inputValue)))
                        Console.WriteLine("\nUse correct digits");

                    q.Enqueue(inputValue);

                }
                else if (userInput == 'h')
                {
                    int tailValue = 0;
                    Console.WriteLine();
                    if (q.Dequeue(ref tailValue))
                        Console.WriteLine(tailValue);
                }
                else
                    Console.WriteLine("\nVälj i eller h");


            }
        }
    }
}
