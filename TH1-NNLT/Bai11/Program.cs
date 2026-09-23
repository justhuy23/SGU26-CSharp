using System;

namespace Bai11
{
    class DaoChuoi
    {
        static string DaoNguoc(string s)
        {
            char[] arr = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[s.Length - 1 - i];
            }

            return new string(arr);
        }

        static void Main()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine() ?? "";

            Console.WriteLine($"Chuoi dao nguoc: {DaoNguoc(s)}");
        }
    }
}