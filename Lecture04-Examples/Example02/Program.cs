﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal enum Status
    { Success = 403, Error, SomeStatus }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Status httpResponse = Status.Error;
            Console.WriteLine(httpResoponse);
            Console.WriteLine((int)httpResoponse);
            Console.WriteLine((int)StatusSomeStatus);
        }
    }
}