using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập số lượng phần tử trong mảng
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        // Khai báo mảng số nguyên có dấu kích thước 8 byte
        long[] numbers = new long[n];

        // Nhập các số nguyên vào mảng
        Console.WriteLine("Nhập các số nguyên vào mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập số thứ {i + 1}: ");
            numbers[i] = long.Parse(Console.ReadLine());
        }

        // Tính tổng của các số trong mảng
        long sum = CalculateSum(numbers);

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của các số trong mảng là: {sum}");
    }

    static long CalculateSum(long[] arr)
    {
        long total = 0;
        foreach (long num in arr)
            /*
foreach (dataType variableName in collectionName)
{
    // Các câu lệnh trong thân vòng lặp
}
            */
        {
            total += num;
        }
        return total;
    }
}