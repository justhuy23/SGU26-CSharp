using System;

namespace Bai14
{
    class NhanVien
    {
        public string HoTen { get; set; } = "";
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        // Tính lương thực nhận
        public double TinhLuong()
        {
            double tru = SoNgayVang * 100000;
            double luongThuc = MucLuong - tru;

            // Không để lương âm
            if (luongThuc < 0) luongThuc = 0;

            return luongThuc;
        }

        public void Xuat()
        {
            Console.WriteLine("\n THONG TIN NHAN VIEN ");
            Console.WriteLine($"Ho ten:          {HoTen}");
            Console.WriteLine($"Muc luong:       {MucLuong:N0} VND");
            Console.WriteLine($"So ngay vang:    {SoNgayVang}");
            Console.WriteLine($"Tien bi tru:     {SoNgayVang * 100000:N0} VND");
            Console.WriteLine($"Luong thuc nhan: {TinhLuong():N0} VND");
        }
    }

    class Program
    {
        static void Main()
        {
            NhanVien nv = new NhanVien();

            nv.Nhap();
            nv.Xuat();
        }
    }
}