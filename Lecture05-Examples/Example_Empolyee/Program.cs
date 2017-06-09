using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Empolyee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Empolyee data = new Empolyee();
            Console.Write("請輸入底薪及獎金:");
            double temperature = double.Parse(Console.ReadLine());

            data.GetEmpolyee = Empolyee;
            Console.WriteLine("您輸入的是{0}, 結果是{1}", temperature, data.Temperature);
        }
    }
}