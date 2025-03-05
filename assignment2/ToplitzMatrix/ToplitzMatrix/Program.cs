using System;

class ToplitzMatrix
{
    static bool IsToplitz(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                if (matrix[i, j] != matrix[i + 1, j + 1])
                {
                    return false;
                }
            }
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine("请输入矩阵行数：");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("请输入矩阵列数：");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[m, n];
        Console.WriteLine("请按行输入矩阵元素，每个元素之间用空格隔开：");
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        bool result = IsToplitz(matrix);
        Console.WriteLine(result);
    }
}