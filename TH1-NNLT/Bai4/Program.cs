using System;

namespace Bai4
{
    class NhapSoNguyenCoKiemTra
    {
        static void Main()
        {
            int x, y;

            // Nhập x với kiểm tra
            while (true)
            {
                Console.Write("Nhap so nguyen x: ");
                string inputX = Console.ReadLine();
                
                if (int.TryParse(inputX, out x))
                    break;
                
                Console.WriteLine("Loi: x khong phai la so nguyen! Vui long nhap lai.");
            }

            // Nhập y với kiểm tra
            while (true)
            {
                Console.Write("Nhap so nguyen y: ");
                string inputY = Console.ReadLine();
                
                if (int.TryParse(inputY, out y))
                    break;
                
                Console.WriteLine("Loi: y khong phai la so nguyen! Vui long nhap lai.");
            }

            long ketQua = (long)Math.Pow(x, y);

            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}