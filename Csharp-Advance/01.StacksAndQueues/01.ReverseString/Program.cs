using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                stack.Push(text[i]);
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}
