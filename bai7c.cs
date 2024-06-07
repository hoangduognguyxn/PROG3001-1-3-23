﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập số nguyên không dấu 4 byte
        Console.Write("Nhập số nguyên không dấu (từ 0 đến 4.294.967.295): ");
        uint number = uint.Parse(Console.ReadLine());

        // Kiểm tra xem số đó là chẵn hay lẻ
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} là số chẵn.");
        }
        else
        {
            Console.WriteLine($"{number} là số lẻ.");
        }
    }
}