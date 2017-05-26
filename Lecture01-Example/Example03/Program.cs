using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student someone = new Student();
            someone.name = "QQ";
            someone.birthday = "1/1";
            Console.WriteLine("你的姓名:{0}你的生日:{1}", someone.name,someone.birthday);
        }
    }
}
