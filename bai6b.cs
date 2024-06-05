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

        // Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        double max = numbers[0];
        double min = numbers[0];

        foreach (double num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        // In kết quả lên màn hình
        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");
    }
}