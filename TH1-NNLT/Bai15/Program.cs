using System;

namespace Bai15
{
    class MangSoNguyen
    {
        // 1. Nhập mảng
        public static int[] NhapMang()
        {
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        // 2. In mảng ra màn hình
        public static void InMang(int[] a)
        {
            Console.Write("Mang: ");
            foreach (int x in a)
                Console.Write($"{x} ");
            Console.WriteLine();
        }

        // 3. Tìm max và min (dùng out để trả về 2 giá trị)
        public static void TimMinMax(int[] a, out int min, out int max)
        {
            min = a[0];
            max = a[0];
            foreach (int x in a)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }
        }

        // 4. Trả về mảng các số nguyên tố
        public static int[] LaySoNguyenTo(int[] a)
        {
            int dem = 0;
            // Đếm số lượng số nguyên tố
            foreach (int x in a)
                if (LaNguyenTo(x)) dem++;

            // Tạo mảng kết quả
            int[] ketQua = new int[dem];
            int j = 0;
            foreach (int x in a)
            {
                if (LaNguyenTo(x))
                {
                    ketQua[j] = x;
                    j++;
                }
            }
            return ketQua;
        }

        // Hàm phụ kiểm tra số nguyên tố
        static bool LaNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Main()
        {
            int[] a = NhapMang();
            InMang(a);

            TimMinMax(a, out int min, out int max);
            Console.WriteLine($"Min = {min}, Max = {max}");

            int[] nguyenTo = LaySoNguyenTo(a);
            Console.Write("Cac so nguyen to: ");
            foreach (int x in nguyenTo)
                Console.Write($"{x} ");
            Console.WriteLine();
        }
    }
}