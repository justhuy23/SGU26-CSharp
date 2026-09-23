using System;

namespace Bai12
{
    class XuLyChuoi
    {
        static void Main()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine() ?? "";

            // 1. Chuyển sang chữ thường
            string chuThuong = s.ToLower();
            Console.WriteLine($"Chu thuong: {chuThuong}");

            // 2. Chuyển sang chữ hoa
            string chuHoa = s.ToUpper();
            Console.WriteLine($"Chu hoa: {chuHoa}");

            // 3. Đếm số từ
            string[] tu = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"So tu trong chuoi: {tu.Length}");
        }
    }
}