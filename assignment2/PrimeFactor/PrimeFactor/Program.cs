﻿using System;
class PrimeFactor
{
    static void Main()
    {
        Console.WriteLine("请输入一个数据");
        int n = int.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine("请输入大于1的数");
            return;
        }
        if (n % 2 == 0)
        {
            Console.WriteLine("2");
            n = n / 2;
            while (n % 2 == 0)
            {
                n /= 2;
            }
        }
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
            {
                Console.WriteLine($"{i}");
                n = n / i;
            }
            while (n % i == 0)
            {
                n /= i;
            }
        }
        if (n > 1)
        {
            Console.WriteLine($"{n}");
        }
    }

}
