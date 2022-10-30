using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(array);
            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] commandArg = command.Split(' ');

                if (commandArg[0] == "add")
                {
                    int firstNumber = int.Parse(commandArg[1]);
                    int secondNumber = int.Parse(commandArg[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else
                {
                    int number = int.Parse(commandArg[1]);

                    if (stack.Count >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
