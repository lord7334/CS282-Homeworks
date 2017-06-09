using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Empolyee
{
    public class Empolyee
    {
        private double basesalary;
        private double benefit;
        public double salary;

        public double BaseSalary
        {
            get
            {
                return this.basesalary;
            }

            set
            {
                if (value > 50000)
                {
                    this.basesalary = 50000;
                }
                else if (value < 21009)
                {
                    this.basesalary = 21009;
                }
                else
                {
                    this.basesalary = value;
                }
            }
        }

        public double Humidity
        {
            get => benefit;
            set => benefit = value;
        }

        public void SetEmpolyee(double value)
        {
            if (value > 50000)
            {
                this.basesalary = 50000;
            }
            else if (value < 21009)
            {
                this.basesalary = 21009;
            }
            else
            {
                this.basesalary = value;
            }
        }

        public double GetEmpolyee()
        {
            return this.basesalary;
        }

        public bool Equals(Empolyee other)
        {
            return this.BaseSalary == other.BaseSalary
                   && this.Humidity == other.Humidity
                   && this.salary == other.salary;
        }
    }
}