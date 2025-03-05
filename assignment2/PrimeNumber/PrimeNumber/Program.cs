using System;

class PrimeNumber
{
    static void Main()
    {
        const int n = 100;
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }
        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
        Console.WriteLine("2到100以内的素数为：");
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}