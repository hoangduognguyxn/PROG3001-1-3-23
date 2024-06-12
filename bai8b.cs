﻿// Tham khảo AI


using System;
using System.Text;

class bai8b
{
    static void Main(string[] args)
    {
        // Thiết lập trang mã UTF-8
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Encoding utf8 = Encoding.GetEncoding(65001);

        // In tiêu đề
        Console.OutputEncoding = utf8;
        Console.WriteLine("Bảng mã UTF-8 (trang mã 65001)");
        Console.WriteLine("============================");
        Console.WriteLine("Ký tự\tMã UTF-8");
        Console.WriteLine("-----\t---------");

        // Hiển thị bảng mã UTF-8
        for (int i = 0; i <= 0x10FFFF; i++)
        {
            if (char.IsLetterOrDigit((char)i) || char.IsPunctuation((char)i) || char.IsWhiteSpace((char)i))
            {
                byte[] bytes = utf8.GetBytes(new char[] { (char)i });
                string byteString = string.Join(", ", bytes);
                Console.WriteLine("{0}\t{1}", (char)i, byteString);
            }
        }

        Console.ReadLine(); // Tạm dừng chương trình để người dùng có thể xem kết quả
    }
}