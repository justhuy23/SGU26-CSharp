using System;

namespace Bai17
{
    class MaTranNgauNhien
    {
        // 1. Sinh ma trận ngẫu nhiên [n][m] với giá trị [10, 100]
        public static int[,] SinhMaTran(int n, int m)
        {
            Random rd = new Random();
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rd.Next(10, 101);   // 10 → 100

            return a;
        }

        // 2. In ma trận
        public static void InMaTran(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{a[i, j],5}");
                Console.WriteLine();
            }
        }

        // 3. Tách mảng chẵn và lẻ
        public static void TachChanLe(int[,] a, out int[] chan, out int[] le)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            // Đếm số chẵn và lẻ
            int demChan = 0, demLe = 0;
            foreach (int x in a)
            {
                if (x % 2 == 0) demChan++;
                else demLe++;
            }

            // Tạo mảng kết quả
            chan = new int[demChan];
            le = new int[demLe];
            int iChan = 0, iLe = 0;

            foreach (int x in a)
            {
                if (x % 2 == 0)
                    chan[iChan++] = x;
                else
                    le[iLe++] = x;
            }
        }

        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] a = SinhMaTran(n, m);

            Console.WriteLine("\nMa tran ngau nhien:");
            InMaTran(a);

            TachChanLe(a, out int[] chan, out int[] le);

            Console.WriteLine("\nMang so chan:");
            foreach (int x in chan) Console.Write($"{x} ");

            Console.WriteLine("\n\nMang so le:");
            foreach (int x in le) Console.Write($"{x} ");
            Console.WriteLine();
        }
    }
}