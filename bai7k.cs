using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập số nguyên không âm
        Console.Write("Nhập số nguyên không âm: ");
        int n = int.Parse(Console.ReadLine());

        // Tính giai thừa
        long factorial = CalculateFactorial(n);

        // In kết quả lên màn hình
        Console.WriteLine($"Giai thừa của {n} là: {factorial}");
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}