using System;

class Program
{
    static void Main()
    {
        // Nhập mảng số thực 4 byte từ người dùng
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        float[] numbers = new float[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            numbers[i] = float.Parse(Console.ReadLine());
        }

        // Tính tổng của các số trong mảng
        float sum = 0;
        foreach (float num in numbers)
        {
            sum += num;
        }

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của các số trong mảng là: {sum}");
    }
}