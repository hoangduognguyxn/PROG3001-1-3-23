using System;

class Program
{
    static bool IsPerfectNumber(int n)
    {
        /*
         * Kiểm tra xem số n có phải là số hoàn hảo hay không.
         * Số hoàn hảo là số mà tổng các ước số của nó (không tính chính nó) bằng chính nó.
         */
        int divisorsSum = 0;
        for (int divisor = 1; divisor < n; divisor++)
        {
            if (n % divisor == 0)
            {
                divisorsSum += divisor;
            }
        }
        return divisorsSum == n;
    }

    static void Main(string[] args)
    {
        // Nhận vào số nguyên từ người dùng
        Console.Write("Nhập số nguyên: ");
        int num = int.Parse(Console.ReadLine());

        // Kiểm tra xem số đó có phải là số hoàn hảo hay không
        if (IsPerfectNumber(num))
        {
            Console.WriteLine($"{num} là số hoàn hảo.");
        }
        else
        {
            Console.WriteLine($"{num} không phải là số hoàn hảo.");
        }
    }
}