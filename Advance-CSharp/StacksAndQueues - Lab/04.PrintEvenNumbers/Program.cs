using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> evenNumbers = new Queue<int>();

            int[] integersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < integersArr.Length; i++)
            {
                if (integersArr[i] % 2 == 0)
                {
                    int evenNumber = integersArr[i];
                    evenNumbers.Enqueue(evenNumber);
                }
            }
            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
