using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập ba số nguyên
        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());

        // Tìm số lớn nhất
        int max = num1;
        if (num2 > max)
            max = num2;
        if (num3 > max)
            max = num3;

        // In kết quả lên màn hình
        Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
    }
}