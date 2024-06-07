using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập số nguyên không âm
        Console.Write("Nhập số nguyên không âm: ");
        int n = int.Parse(Console.ReadLine());

        // Kiểm tra xem số đó có phải là số nguyên tố hay không
        bool isPrime = CheckPrime(n);

        // In kết quả lên màn hình
        if (isPrime)
            Console.WriteLine($"{n} là số nguyên tố.");
        else
            Console.WriteLine($"{n} không phải là số nguyên tố.");
    }

    static bool CheckPrime(int n)
    {
        if (n < 2)
            return false;
        if (n == 2)
            return true;
        if (n % 2 == 0)
            return false;

        int sqrt = (int)Math.Sqrt(n);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}