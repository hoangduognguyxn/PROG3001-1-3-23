using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập số nguyên không dấu kích thước 8 byte từ người dùng
        Console.Write("Nhập số nguyên không dấu (8 byte): ");
        ulong number = ulong.Parse(Console.ReadLine());

        // Kiểm tra xem số đó có phải là số Palindrome hay không
        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} là số Palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số Palindrome.");
        }
    }

    static bool IsPalindrome(ulong num)
    {
        ulong originalNum = num;
        ulong reversedNum = 0;

        // Đảo ngược số
        while (num > 0)
        {
            reversedNum = reversedNum * 10 + (num % 10);
            num /= 10;
        }

        // So sánh số gốc và số đảo ngược
        return originalNum == reversedNum;
    }
}