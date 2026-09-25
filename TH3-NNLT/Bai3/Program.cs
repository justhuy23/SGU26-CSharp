using System;
using System.Collections.Generic;

namespace OOP_BaiTap_Chuong3
{
    // ============================================================
    // BÀI 3.1: Sắp xếp bằng Array.Sort + IComparable
    // ============================================================
    class SinhVien : IComparable<SinhVien>
    {
        public string HoTen { get; set; } = "";
        public double DiemTB { get; set; }

        public SinhVien() { }
        public SinhVien(string hoTen, double diemTB)
        {
            HoTen = hoTen;
            DiemTB = diemTB;
        }

        // Cài đặt IComparable — sắp xếp theo điểm tăng dần
        public int CompareTo(SinhVien? other)
        {
            if (other == null) return 1;
            return this.DiemTB.CompareTo(other.DiemTB);
        }

        public override string ToString() => $"{HoTen} ({DiemTB})";
    }

    // ============================================================
    // BÀI 3.2: Sắp xếp mảng tổng quát bằng Interface
    // ============================================================
    interface ISoSanh<T>
    {
        int SoSanh(T a, T b);
    }

    class SapXepInterface
    {
        // Sắp xếp tổng quát dùng interface ISoSanh<T>
        public static void SapXep<T>(T[] arr, ISoSanh<T> cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (cmp.SoSanh(arr[i], arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }

    // So sánh số nguyên
    class SoSanhInt : ISoSanh<int>
    {
        public int SoSanh(int a, int b) => a.CompareTo(b);
    }

    // So sánh sinh viên theo điểm
    class SoSanhSinhVien : ISoSanh<SinhVien>
    {
        public int SoSanh(SinhVien a, SinhVien b) => a.DiemTB.CompareTo(b.DiemTB);
    }

    // ============================================================
    // BÀI 3.3: Sắp xếp mảng tổng quát bằng Delegate
    // ============================================================
    class SapXepDelegate
    {
        // Delegate so sánh 2 phần tử
        public delegate int SoSanhDelegate<T>(T a, T b);

        public static void SapXep<T>(T[] arr, SoSanhDelegate<T> cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (cmp(arr[i], arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }

    // ============================================================
    // BÀI 3.4: ConsoleMenu (Event) + PTBac2Console (Kế thừa)
    // ============================================================
    class ConsoleMenu
    {
        // Event: khi người dùng chọn chức năng
        public event Action<int>? Choose;

        protected virtual void HienThiMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Chức năng 1");
            Console.WriteLine("2. Chức năng 2");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Thực hiện: ");
        }

        protected virtual void XuLyChucNang(int chon)
        {
            Console.WriteLine($"Bạn thực hiện chức năng {chon}");
        }

        public void Run()
        {
            while (true)
            {
                HienThiMenu();
                int chon = int.Parse(Console.ReadLine() ?? "0");

                // Kích hoạt event
                Choose?.Invoke(chon);

                XuLyChucNang(chon);

                if (chon == 0) break;
                Console.WriteLine();
            }
        }
    }

    // Lớp PTBac2Console kế thừa ConsoleMenu
    class PTBac2Console : ConsoleMenu
    {
        public PTBac2Console()
        {
            // Đăng ký event Choose
            Choose += (chon) =>
            {
                if (chon == 1) GiaiPTBac2();
                else if (chon == 2) Console.WriteLine("Chức năng 2 đang xây dựng...");
            };
        }

        protected override void HienThiMenu()
        {
            Console.WriteLine("--- GIẢI PHƯƠNG TRÌNH BẬC 2 ---");
            Console.WriteLine("1. Giải PT bậc 2");
            Console.WriteLine("2. Chức năng khác");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Thực hiện: ");
        }

        void GiaiPTBac2()
        {
            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine(b == 0
                    ? (c == 0 ? "Vô số nghiệm" : "Vô nghiệm")
                    : $"PT bậc 1, x = {-c / b}");
                return;
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0) Console.WriteLine("Vô nghiệm");
            else if (delta == 0) Console.WriteLine($"Nghiệm kép x = {-b / (2 * a):F2}");
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
            }
        }
    }

    // ============================================================
    // BÀI 3.5: Tính lương nhân viên (Kế thừa + Đa hình)
    // ============================================================
    abstract class NhanVien
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";

        public abstract double TinhLuong();
        public abstract void Xuat();
    }

    class NhanVienKinhDoanh : NhanVien
    {
        public double MucLuong { get; set; }
        public double DoanhThu { get; set; }   // đơn vị: triệu

        public override double TinhLuong()
        {
            double hoaHong = DoanhThu * 0.05;   // 5% doanh thu
            // Giới hạn hoa hồng: 500k - 1 triệu
            if (hoaHong < 500000) hoaHong = 500000;
            if (hoaHong > 1000000) hoaHong = 1000000;
            return MucLuong + hoaHong;
        }

        public override void Xuat()
        {
            Console.WriteLine($"[KD] {MaNV} - {HoTen} | Lương CB: {MucLuong:N0} | DT: {DoanhThu}tr | Lương: {TinhLuong():N0}");
        }
    }

    class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }

        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;   // 1000đ/sp
            if (SoSanPham > 3000)
                luong += luong * 0.05;         // thêm 5%
            return luong;
        }

        public override void Xuat()
        {
            Console.WriteLine($"[SX] {MaNV} - {HoTen} | SP: {SoSanPham} | Lương: {TinhLuong():N0}");
        }
    }

    // ============================================================
    // BÀI 3.6: Cuộc thi (Kế thừa + Đa hình)
    // ============================================================
    class ThiSinh
    {
        public string SBD { get; set; } = "";
        public string HoTen { get; set; } = "";
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }
        public double TongDiem { get; set; }

        public virtual void Nhap()
        {
            Console.Write("SBD: "); SBD = Console.ReadLine() ?? "";
            Console.Write("Họ tên: "); HoTen = Console.ReadLine() ?? "";
            Console.Write("Bài 1: "); Bai1 = double.Parse(Console.ReadLine());
            Console.Write("Bài 2: "); Bai2 = double.Parse(Console.ReadLine());
            Console.Write("Bài 3: "); Bai3 = double.Parse(Console.ReadLine());
        }

        public virtual double TinhTongDiem() => Bai1 + Bai2 + Bai3;

        public virtual void Xuat()
        {
            TongDiem = TinhTongDiem();
            Console.WriteLine($"{SBD} - {HoTen} | B1={Bai1}, B2={Bai2}, B3={Bai3} | Tổng = {TongDiem:F2}");
        }
    }

    class Chuyen : ThiSinh
    {
        public double TiengAnh { get; set; }   // điểm tiếng Anh (thang 10)

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Tiếng Anh: ");
            TiengAnh = double.Parse(Console.ReadLine());
        }

        public override double TinhTongDiem()
        {
            double diem = base.TinhTongDiem();
            // 7 <= TA < 8: +1, 9 <= TA <= 10: +2
            if (TiengAnh >= 7 && TiengAnh < 8) diem += 1;
            else if (TiengAnh >= 9 && TiengAnh <= 10) diem += 2;
            return diem;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"    → Chuyên | Tiếng Anh: {TiengAnh} | Tổng cuối: {TinhTongDiem():F2}");
        }
    }

    class SieuCap : ThiSinh
    {
        public double Csdl { get; set; }   // điểm CSDL

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm CSDL: ");
            Csdl = double.Parse(Console.ReadLine());
        }

        // Tổng 4 bài
        public override double TinhTongDiem() => base.TinhTongDiem() + Csdl;

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"    → Siêu cấp | CSDL: {Csdl} | Tổng cuối: {TinhTongDiem():F2}");
        }
    }

    class CuocThi
    {
        private List<ThiSinh> ds = new List<ThiSinh>();

        public void Nhap()
        {
            Console.Write("Số thí sinh chuyên: ");
            int nChuyen = int.Parse(Console.ReadLine());
            for (int i = 0; i < nChuyen; i++)
            {
                Console.WriteLine($"--- Thí sinh Chuyên {i + 1} ---");
                ThiSinh ts = new Chuyen();
                ts.Nhap();
                ds.Add(ts);
            }

            Console.Write("Số thí sinh siêu cấp: ");
            int nSieuCap = int.Parse(Console.ReadLine());
            for (int i = 0; i < nSieuCap; i++)
            {
                Console.WriteLine($"--- Thí sinh Siêu cấp {i + 1} ---");
                ThiSinh ts = new SieuCap();
                ts.Nhap();
                ds.Add(ts);
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\n===== KẾT QUẢ CUỘC THI =====");
            foreach (ThiSinh ts in ds)
                ts.Xuat();
        }
    }

    // ============================================================
    // CHƯƠNG TRÌNH CHÍNH
    // ============================================================
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ===== BÀI 3.1 =====
            Console.WriteLine("===== BÀI 3.1: Array.Sort + IComparable =====");
            SinhVien[] dsSV = {
                new SinhVien("Minh", 8.5),
                new SinhVien("An",   9.0),
                new SinhVien("Bình", 7.0),
            };
            Array.Sort(dsSV);   // dùng CompareTo
            foreach (var sv in dsSV) Console.WriteLine(sv);

            // ===== BÀI 3.2 =====
            Console.WriteLine("\n===== BÀI 3.2: Sắp xếp bằng Interface =====");
            int[] arr = { 5, 2, 9, 1, 7 };
            SapXepInterface.SapXep(arr, new SoSanhInt());
            Console.WriteLine("Mảng sau sắp xếp: " + string.Join(" ", arr));

            SinhVien[] dsSV2 = {
                new SinhVien("Minh", 8.5),
                new SinhVien("An",   9.0),
                new SinhVien("Bình", 7.0),
            };
            SapXepInterface.SapXep(dsSV2, new SoSanhSinhVien());
            Console.WriteLine("SV sau sắp xếp:");
            foreach (var sv in dsSV2) Console.WriteLine("  " + sv);

            // ===== BÀI 3.3 =====
            Console.WriteLine("\n===== BÀI 3.3: Sắp xếp bằng Delegate =====");
            int[] arr2 = { 5, 2, 9, 1, 7 };
            SapXepDelegate.SapXep(arr2, (a, b) => a.CompareTo(b));
            Console.WriteLine("Mảng: " + string.Join(" ", arr2));

            // ===== BÀI 3.4 =====
            Console.WriteLine("\n===== BÀI 3.4: ConsoleMenu + PTBac2Console =====");
            PTBac2Console app = new PTBac2Console();
            app.Choose += (chon) => Console.WriteLine($"[EVENT] Bạn đã chọn: {chon}");
            app.Run();

            // ===== BÀI 3.5 =====
            Console.WriteLine("\n===== BÀI 3.5: Tính lương nhân viên =====");
            List<NhanVien> dsNV = new List<NhanVien>
            {
                new NhanVienKinhDoanh { MaNV = "KD01", HoTen = "Nguyễn A", MucLuong = 5000000, DoanhThu = 30 },
                new NhanVienKinhDoanh { MaNV = "KD02", HoTen = "Trần B",   MucLuong = 6000000, DoanhThu = 5 },
                new NhanVienSanXuat   { MaNV = "SX01", HoTen = "Lê C",     SoSanPham = 3500 },
                new NhanVienSanXuat   { MaNV = "SX02", HoTen = "Phạm D",   SoSanPham = 2000 },
            };
            foreach (var nv in dsNV) nv.Xuat();

            // ===== BÀI 3.6 =====
            Console.WriteLine("\n===== BÀI 3.6: Cuộc thi =====");
            CuocThi ct = new CuocThi();
            // Nhập tay 1 chuyên + 1 siêu cấp
            Console.WriteLine("--- Thí sinh Chuyên ---");
            ThiSinh t1 = new Chuyen();
            t1.Nhap();
            ct.GetType();  // không cần
            // Dùng danh sách nội bộ
            // (đơn giản hoá: dùng list cục bộ)
            List<ThiSinh> dsThi = new List<ThiSinh> { t1 };

            Console.WriteLine("--- Thí sinh Siêu cấp ---");
            ThiSinh t2 = new SieuCap();
            t2.Nhap();
            dsThi.Add(t2);

            Console.WriteLine("\n===== KẾT QUẢ =====");
            foreach (var ts in dsThi) ts.Xuat();
        }
    }
}