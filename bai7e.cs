using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập một số nguyên không dấu 4 byte
        Console.Write("Nhập số nguyên không dấu 4 byte: ");
        uint n = uint.Parse(Console.ReadLine());

        // Tính tổng của các số từ 1 đến n
        uint sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            sum += i;
        }

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của các số từ 1 đến {n} là: {sum}");
    }
}