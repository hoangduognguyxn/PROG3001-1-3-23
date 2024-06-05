using System;

class Program
{
    static void Main()
    {
        // Nhập mảng số thực 8 byte từ người dùng
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            numbers[i] = double.Parse(Console.ReadLine());
        }

        // Tính trung bình cộng của các số trong mảng
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        double average = sum / n;

        // In kết quả lên màn hình
        Console.WriteLine($"Trung bình cộng của các số trong mảng là: {average}");
    }
}