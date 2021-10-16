using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int n1 = start; n1 <= end; n1++)
            {
                for (int n2 = start; n2 <= end; n2++)
                {
                    counter++;
                    if (n1 + n2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({n1} + {n2} = {magicNumber})");
                        return;
                    }
                }              
            }  
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
