using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a = 1.0f;
            double b = 0.33f;
            double sum = 1.33f;
            double SUM = a + b;
            bool equal = (a + b == SUM);
            Console.WriteLine("a+b={0}  sum={1}  equal={2}  A={3}   B={4} A+B={5}",
                a + b, sum, equal, a, b, SUM);
        }
    }
}