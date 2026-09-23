using System;

namespace Bai9
{
    class TimMinMax
    {
        // Phương thức tìm min, max — trả về qua tham số out
        static void TimMinMax(double a, double b, double c, out double min, out double max)
        {
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;

            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
        }

        static void Main()
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            double min, max;
            TimMinMax(a, b, c, out min, out max);

            Console.WriteLine($"Gia tri nho nhat: {min}");
            Console.WriteLine($"Gia tri lon nhat: {max}");
        }
    }
}