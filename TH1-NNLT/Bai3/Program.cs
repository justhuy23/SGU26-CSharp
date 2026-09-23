using System;

namespace Bai3
{
    class NhapSoNguyen
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());

            long ketQua = (long)Math.Pow(x, y);

            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + ketQua);
        }
    }
}