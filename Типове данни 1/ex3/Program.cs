﻿using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = Convert.ToInt32(input, 16);
            Console.WriteLine(output);
        }
    }
}
