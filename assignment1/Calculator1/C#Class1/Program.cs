using System;

namespace myApp
{ class Calculator
    {
        static void Main()
        {
            Console.Write("请输入第一个数字：");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("输入的第一个数字无效");
                return;
            }
            Console.Write("请输入运算符：");
            string? op = Console.ReadLine();
            Console.Write("请输入第二个数字：");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("输入的第二个数字无效");
                return;
            }
            double result = 0;
            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;
            else
                Console.WriteLine("输入的运算符无效");
            Console.WriteLine($"计算结果是：{result}");
        }
    }

}
