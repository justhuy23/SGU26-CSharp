using System;

namespace Bai7
{
    class KiemTraNguyenTo
    {
        // Phương thức trả về true nếu n là số nguyên tố
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            if (LaSoNguyenTo(n))
                Console.WriteLine($"{n} la so nguyen to.");
            else
                Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
    }
}