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

        // Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        float max = numbers[0];
        float min = numbers[0];

        foreach (float num in numbers)
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