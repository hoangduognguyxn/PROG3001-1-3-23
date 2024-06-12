﻿// Không cài đc assembly reference

using System;
using System.Threading;
using System.Windows.Forms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhấn phím space để phát tiếng beep. Nhấn Esc để thoát.");

        while (true)
        {
            // Kiểm tra nếu phím space được nhấn
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                // Phát tiếng beep
                Console.Beep();
            }

            // Kiểm tra nếu phím Esc được nhấn
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                // Thoát khỏi chương trình
                break;
            }

            // Dừng lại một chút để không tiêu tốn nhiều tài nguyên
            Thread.Sleep(100);
        }

        Console.WriteLine("Chương trình đã kết thúc.");
    }
}