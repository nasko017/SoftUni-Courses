using System;

namespace TraficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int passedCount= 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            passedCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);

                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
