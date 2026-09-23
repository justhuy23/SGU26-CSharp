using System;

namespace Bai5
{
    class MenuChuongTrinh
    {
        static void Main()
        {
            double x = 0, y = 0;
            int chon;

            do
            {
                // Hiển thị menu
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                // Nhập lựa chọn (có kiểm tra)
                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    continue;
                }

                // Xử lý lựa chọn
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap x: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Nhap y: ");
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Da nhap x = {x}, y = {y}");
                        break;

                    case 2:
                        double ketQua = Math.Pow(x, y);
                        Console.WriteLine($"Ket qua {x}^{y} = {ketQua}");
                        break;

                    case 3:
                        if (x < 0 || y < 0)
                        {
                            Console.WriteLine("Khong the tinh can bac 2 cua so am!");
                        }
                        else
                        {
                            Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}");
                            Console.WriteLine($"Can bac 2 cua {y} = {Math.Sqrt(y)}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Tam biet!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long chon 1-4.");
                        break;
                }

                Console.WriteLine(); // Dòng trống cho dễ đọc

            } while (chon != 4);
        }
    }
}