﻿using System;

namespace ITC_Github_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            n = numInput();
            m = numInput();

            n += m;
            Console.WriteLine("合計は{0}", n);
            Console.WriteLine(n);
            Console.Read();
        }

        static int numInput()
        {
            int num;
            Console.Write("数字を入力してください ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
