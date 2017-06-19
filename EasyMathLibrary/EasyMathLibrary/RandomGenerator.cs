using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Random
    {
        private System.Random random;

        public Random()
        {
            random = new System.Random();
        }

        public double NextDouble(double start, double end)
        {
            return random.NextDouble() * (end - start) + start;
        }

        public double NextDouble()
        {
            return random.NextDouble();
        }

        public int Next(int start, int end)
        {
            return this.random.Next(start, end);
        }
    }
}