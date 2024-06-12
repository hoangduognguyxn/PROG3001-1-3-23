﻿using System;
using System.IO;

class bai11
{
    static void Main(string[] args)
    {
        // Nhập tên file
        Console.Write("Nhập tên file: ");
        string fileName = Console.ReadLine();

        // Nhập nội dung file
        Console.WriteLine("Nhập nội dung file (gõ 'end' để kết thúc):");
        string content = "";
        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            content += line + Environment.NewLine;
        }

        // Ghi nội dung vào file
        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine($"Đã ghi nội dung vào file {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
        }

        // Đọc nội dung từ file và hiển thị lên màn hình
        try
        {
            string readContent = File.ReadAllText(fileName);
            Console.WriteLine($"Nội dung file {fileName}:");
            Console.WriteLine(readContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
        }
    }
}