using System;

namespace OOP_BaiTap
{
    // ============================================================
    // BÀI 1.1: Tính tuổi 1 sinh viên
    // ============================================================
    class SinhVien
    {
        public string HoTen { get; set; } = "";
        public int NamSinh { get; set; }

        public SinhVien() { }

        public SinhVien(string hoTen, int namSinh)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "";
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        public int TinhTuoi()
        {
            return DateTime.Now.Year - NamSinh;
        }

        public void Xuat()
        {
            Console.WriteLine($"Sinh vien: {HoTen}, Nam sinh: {NamSinh}, Tuoi: {TinhTuoi()}");
        }
    }

    // ============================================================
    // BÀI 1.2: Lớp Point
    // ============================================================
    class Point
    {
        // Field
        private double x, y;

        // Property
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Default Constructor
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Constructor có tham số
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Copy Constructor
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        // Output
        public void Output()
        {
            Console.WriteLine($"Point({x}, {y})");
        }

        // Override ToString
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // (a) Phương thức thành viên: Khoảng cách
        public double KhoangCach(Point p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }

        // (a) Phương thức tĩnh: Khoảng cách
        public static double KhoangCach(Point a, Point b)
        {
            return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
        }

        // (b) Phương thức thành viên: Trung điểm
        public Point TrungDiem(Point p)
        {
            return new Point((x + p.x) / 2, (y + p.y) / 2);
        }

        // (b) Phương thức tĩnh: Trung điểm
        public static Point TrungDiem(Point a, Point b)
        {
            return new Point((a.x + b.x) / 2, (a.y + b.y) / 2);
        }

        // Phép toán +, -, lấy âm
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }

        public static Point operator -(Point a)
        {
            return new Point(-a.x, -a.y);
        }
    }

    // ============================================================
    // BÀI 1.3: Lớp Person
    // ============================================================
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Yob { get; set; }

        // Default Constructor
        public Person() { }

        // Copy Constructor
        public Person(Person p)
        {
            Id = p.Id;
            Name = p.Name;
            Yob = p.Yob;
        }

        // Constructor có tham số
        public Person(int id, string name, int yob)
        {
            Id = id;
            Name = name;
            Yob = yob;
        }

        public void Input()
        {
            Console.Write("Nhap id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap name: ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Nhap yob: ");
            Yob = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Person({Id}, {Name}, {Yob})");
        }

        // IsLiving: false nếu yob == 0
        public bool IsLiving()
        {
            return Yob != 0;
        }
    }

    // ============================================================
    // BÀI 1.4: Lớp Phân số
    // ============================================================
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        // Constructor mặc nhiên
        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau == 0 ? 1 : mau;   // tránh mẫu = 0
        }

        // Copy Constructor
        public PhanSo(PhanSo p)
        {
            Tu = p.Tu;
            Mau = p.Mau;
        }

        // Tìm ƯCLN
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }

        // Rút gọn
        public void RutGon()
        {
            int u = UCLN(Tu, Mau);
            Tu /= u;
            Mau /= u;
            if (Mau < 0)
            {
                Tu = -Tu;
                Mau = -Mau;
            }
        }

        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }

        // ===== Overload toán tử =====

        // Một ngôi: +, -
        public static PhanSo operator +(PhanSo a) => new PhanSo(a.Tu, a.Mau);
        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.Tu, a.Mau);

        // Hai ngôi: +, -, *, /
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
            kq.RutGon();
            return kq;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
            kq.RutGon();
            return kq;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo(a.Tu * b.Tu, a.Mau * b.Mau);
            kq.RutGon();
            return kq;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo(a.Tu * b.Mau, a.Mau * b.Tu);
            kq.RutGon();
            return kq;
        }

        // So sánh: >, <, >=, <=, ==, !=
        public static bool operator >(PhanSo a, PhanSo b) => a.Tu * b.Mau > b.Tu * a.Mau;
        public static bool operator <(PhanSo a, PhanSo b) => a.Tu * b.Mau < b.Tu * a.Mau;
        public static bool operator >=(PhanSo a, PhanSo b) => a.Tu * b.Mau >= b.Tu * a.Mau;
        public static bool operator <=(PhanSo a, PhanSo b) => a.Tu * b.Mau <= b.Tu * a.Mau;
        public static bool operator ==(PhanSo a, PhanSo b) => a.Tu * b.Mau == b.Tu * a.Mau;
        public static bool operator !=(PhanSo a, PhanSo b) => a.Tu * b.Mau != b.Tu * a.Mau;

        // Bắt buộc override Equals & GetHashCode khi override == và !=
        public override bool Equals(object? obj)
        {
            if (obj is PhanSo p)
                return this == p;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Tu, Mau);
        }
    }

    // ============================================================
    // BÀI 1.5: Lớp Đơn thức
    // ============================================================
    class DonThuc
    {
        public double A { get; set; }   // hệ số
        public int N { get; set; }      // bậc (số nguyên không âm)

        public DonThuc() { }

        public DonThuc(double a, int n)
        {
            A = a;
            N = n >= 0 ? n : 0;
        }

        public void Nhap()
        {
            Console.Write("Nhap he so a: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Nhap bac n (>= 0): ");
            N = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            if (N == 0) return $"{A}";
            if (N == 1) return $"{A}x";
            return $"{A}x^{N}";
        }

        // (a) Tính giá trị đơn thức P(x) = a * x^n
        public double TinhGiaTri(double x)
        {
            return A * Math.Pow(x, N);
        }

        // (b) Đạo hàm P'(x) = a * n * x^(n-1)
        public DonThuc DaoHam()
        {
            if (N == 0) return new DonThuc(0, 0);
            return new DonThuc(A * N, N - 1);
        }
    }

    // ============================================================
    // CHƯƠNG TRÌNH CHÍNH — Test tất cả các bài
    // ============================================================
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ============ BÀI 1.1 ============
            Console.WriteLine("========== BÀI 1.1: SINH VIÊN ==========");
            SinhVien sv = new SinhVien();
            sv.Nhap();
            sv.Xuat();

            // ============ BÀI 1.2 ============
            Console.WriteLine("\n========== BÀI 1.2: POINT ==========");
            Point A = new Point(1, 2);
            Point B = new Point(4, 6);
            Console.WriteLine($"A = {A}, B = {B}");
            Console.WriteLine($"Khoảng cách A-B (thành viên): {A.KhoangCach(B):F2}");
            Console.WriteLine($"Khoảng cách A-B (tĩnh):       {Point.KhoangCach(A, B):F2}");
            Console.WriteLine($"Trung điểm A-B (thành viên): {A.TrungDiem(B)}");
            Console.WriteLine($"Trung điểm A-B (tĩnh):       {Point.TrungDiem(A, B)}");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"-A    = {-A}");

            // ============ BÀI 1.3 ============
            Console.WriteLine("\n========== BÀI 1.3: PERSON ==========");
            Person p1 = new Person(1, "Nguyen Van A", 2005);
            Person p2 = new Person(p1);      // copy constructor
            Person p3 = new Person(2, "B", 0);  // yob = 0

            p1.Output();
            p2.Output();
            p3.Output();
            Console.WriteLine($"p1 IsLiving: {p1.IsLiving()}");
            Console.WriteLine($"p3 IsLiving: {p3.IsLiving()}");

            // ============ BÀI 1.4 ============
            Console.WriteLine("\n========== BÀI 1.4: PHÂN SỐ ==========");
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(3, 4);
            Console.WriteLine($"ps1 = {ps1}");
            Console.WriteLine($"ps2 = {ps2}");
            Console.WriteLine($"ps1 + ps2 = {ps1 + ps2}");
            Console.WriteLine($"ps1 - ps2 = {ps1 - ps2}");
            Console.WriteLine($"ps1 * ps2 = {ps1 * ps2}");
            Console.WriteLine($"ps1 / ps2 = {ps1 / ps2}");
            Console.WriteLine($"-ps1      = {-ps1}");
            Console.WriteLine($"ps1 > ps2? {ps1 > ps2}");
            Console.WriteLine($"ps1 == ps2? {ps1 == ps2}");

            // ============ BÀI 1.5 ============
            Console.WriteLine("\n========== BÀI 1.5: ĐƠN THỨC ==========");
            DonThuc dt = new DonThuc(3, 2);   // 3x^2
            Console.WriteLine($"Đơn thức P = {dt}");
            Console.WriteLine($"P(2) = {dt.TinhGiaTri(2)}");
            DonThuc dh = dt.DaoHam();
            Console.WriteLine($"P'(x) = {dh}");
        }
    }
}