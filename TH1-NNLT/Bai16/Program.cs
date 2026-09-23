using System;

namespace Bai16
{
    class SapXepHoTen
    {
        static void Main()
        {
            Console.Write("Nhap so nguoi n: ");
            int n = int.Parse(Console.ReadLine());

            string[] hoTen = new string[n];

            // Nhập mảng họ tên
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten thu {i + 1}: ");
                hoTen[i] = Console.ReadLine() ?? "";
            }

            // Sắp xếp tăng dần bằng Array.Sort
            Array.Sort(hoTen);

            // In kết quả
            Console.WriteLine("\nDanh sach sau khi sap xep:");
            foreach (string ten in hoTen)
                Console.WriteLine(ten);
        }
    }
}