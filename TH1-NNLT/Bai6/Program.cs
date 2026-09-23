using System;

namespace Bai6
{
    class TimMin
    {
        // Phương thức trả về giá trị nhỏ nhất của 3 số nguyên
        static int TimMinBaSo(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static void Main()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            int min = TimMinBaSo(a, b, c);
            Console.WriteLine($"Gia tri nho nhat cua {a}, {b}, {c} la: {min}");
        }
    }
}