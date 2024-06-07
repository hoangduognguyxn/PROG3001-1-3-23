﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập chiều dài và chiều rộng
        Console.Write("Nhập chiều dài (từ 0 đến 65535): ");
        ushort length = ushort.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng (từ 0 đến 65535): ");
        ushort width = ushort.Parse(Console.ReadLine());

        // Tính diện tích và chu vi
        ushort area = (ushort)(length * width);
        ushort perimeter = (ushort)((length + width) * 2);

        // In kết quả lên màn hình
        Console.WriteLine($"Hình chữ nhật có:");
        Console.WriteLine($"- Chiều dài: {length}");
        Console.WriteLine($"- Chiều rộng: {width}");
        Console.WriteLine($"- Diện tích: {area}");
        Console.WriteLine($"- Chu vi: {perimeter}");
    }
}