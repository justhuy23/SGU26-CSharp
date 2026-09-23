using System;

namespace Bai10
{
    class KiemTraDoiXung
    {
        // Phương thức thành viên kiểm tra chuỗi đối xứng
        static bool LaDoiXung(string s)
        {
            int trai = 0;
            int phai = s.Length - 1;

            while (trai < phai)
            {
                if (s[trai] != s[phai])
                    return false;
                trai++;
                phai--;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine() ?? "";

            if (LaDoiXung(s))
                Console.WriteLine($"\"{s}\" la chuoi doi xung.");
            else
                Console.WriteLine($"\"{s}\" khong phai chuoi doi xung.");
        }
    }
}