using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Box
    {
        public void Result(double lengt, double widt, double heigh)
        {
            if (lengt <= 0)
            {
                Console.WriteLine($"Length cannot be zero or negative.");
                return;
            }
            else if (widt <= 0)
            {
                Console.WriteLine($"Width cannot be zero or negative.");
                return;
            }
            else if (heigh <= 0)
            {
                Console.WriteLine($"Height cannot be zero or negative.");
                return;
            }
            Console.WriteLine($"Surface Area - {(2 * (heigh * lengt) + (2 * (widt * heigh))+ (2*(lengt*widt))):f2}");
            Console.WriteLine($"Lateral Surface Area - {(2*(heigh*lengt)+(2*(widt*heigh))):f2}");
            Console.WriteLine($"Volume - {lengt*widt*heigh:f2}");
        }
    }
}
