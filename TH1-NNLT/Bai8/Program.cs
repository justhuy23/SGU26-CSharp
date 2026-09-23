using System;

namespace Bai8
{
    class HoanVi
    {
        // Phương thức hoán vị 2 số dùng tham chiếu ref
        static void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");

            HoanVi(ref a, ref b);

            Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
        }
    }
}