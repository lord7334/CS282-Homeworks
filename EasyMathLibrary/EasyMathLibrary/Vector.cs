using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public enum OrderBy
    { X, Y, Length }

    public class Vector : IComparable
    {
        #region 屬性的定義

        public double X { get; set; }

        public double Y { get; set; }

        private static Random random;

        public static OrderBy OrderByField;

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion 屬性的定義

        #region 建構式

        public Vector(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector() : this(0, 0)
        {
        }

        public Vector(Vector vector) : this(vector.X, vector.Y)
        {
        }

        #endregion 建構式

        public void Print()
        {
            Console.WriteLine("X:{0}, Y:{1}, Length:{2}", this.X, this.Y, this.Length);
        }

        public Vector Clone()
        {
            return new Vector(this);
        }

        public static Vector Generate(double min, double max)
        {
            if (Vector.random == null)
                Vector.random = new Random();
            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            return new Vector(x, y);
        }

        public static Vector[] Generate(int count, double min, double max)
        {
            Vector[] vectors = new Vector[count];
            for (int index = 0; index < vectors.Length; index++)
            {
                vectors[index] = Vector.Generate(min, max);
            }
            return vectors;
        }

        public int CompareTo(object obj)
        {
            Vector other = obj as Vector;
            switch (...)
            {
                case OrderBy.X:
                    if (this.X > other.X)
                        return 1;
                    else if (this.X < other.X)
                        return -1;
                    else
                        return 0;

                case OrderBy.Y:
                    if (this.Y > other.Y)
                        return 1;
                    else if (this.Y < other.Y)
                        return -1;
                    else
                        return 0;

                case OrderBy.Length:
                    if (this.Length > other.Length)
                        return 1;
                    else if (this.Length < other.Length)
                        return -1;
                    else
                        return 0;

                default:
                    if (this.Length > other.Length)
                        return 1;
                    else if (this.Length < other.Length)
                        return -1;
                    else
                        return 0;
            }
        }
    }
}