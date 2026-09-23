using System;

namespace Bai13
{
    // Khai báo lớp SinhVien
    class SinhVien
    {
        // Thuộc tính (fields)
        public string MaSV;
        public string HoTen;
        public string DiaChi;
        public int NamThu;

        // Phương thức nhập thông tin
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine() ?? "";

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? "";

            Console.Write("Nhap sinh vien nam thu may: ");
            NamThu = int.Parse(Console.ReadLine());
        }

        // Phương thức xuất thông tin
        public void Xuat()
        {
            Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
            Console.WriteLine($"Ma sinh vien: {MaSV}");
            Console.WriteLine($"Ho ten:       {HoTen}");
            Console.WriteLine($"Dia chi:      {DiaChi}");
            Console.WriteLine($"Nam thu:      {NamThu}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Tạo đối tượng sinh viên
            SinhVien sv = new SinhVien();

            // Nhập thông tin
            sv.Nhap();

            // Xuất thông tin
            sv.Xuat();
        }
    }
}