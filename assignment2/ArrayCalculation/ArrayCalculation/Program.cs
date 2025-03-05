using System;
class ArrayCalculation
{
    static void Main()
    {
        Console.WriteLine("请输入一串空格分隔的整数");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
        //求最大值
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }
        Console.WriteLine($"最大值为{max}");
        //求最小值
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
        }
        Console.WriteLine($"最小值为{min}");
        //求元素和
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"元素和为{sum}");
        //求平均值
        double average = (double)sum / numbers.Length;
        Console.WriteLine($"平均值为{average}");
    }
}
