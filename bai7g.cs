using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập chiều dài và chiều rộng của hình chữ nhật
        Console.Write("Nhập chiều dài của hình chữ nhật (kiểu số thực 8 byte): ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng của hình chữ nhật (kiểu số thực 8 byte): ");
        double width = double.Parse(Console.ReadLine());

        // Tính diện tích và chu vi của hình chữ nhật
        double area = length * width;
        double perimeter = 2 * (length + width);

        // In kết quả lên màn hình
        Console.WriteLine($"Diện tích của hình chữ nhật là: {area}");
        Console.WriteLine($"Chu vi của hình chữ nhật là: {perimeter}");
    }
}