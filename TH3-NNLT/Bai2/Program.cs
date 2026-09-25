using System;

namespace OOP_BaiTap_Chuong2
{
    // ============================================================
    // BÀI 2.1: Lớp ArrayPoint
    // ============================================================
    class ArrayPoint
    {
        private Point[] arr;
        public int N { get; set; }

        public ArrayPoint(int n)
        {
            N = n;
            arr = new Point[n];
            for (int i = 0; i < n; i++)
                arr[i] = new Point();
        }

        // Indexer
        public Point this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public void Nhap()
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap Point thu {i}:");
                arr[i].Input();
            }
        }

        public void Xuat()
        {
            Console.Write("Danh sach Point: ");
            for (int i = 0; i < N; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }
    }

    // ============================================================
    // Lớp Point (dùng cho 2.1)
    // ============================================================
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point() { X = 0; Y = 0; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point(Point p) { X = p.X; Y = p.Y; }

        public void Input()
        {
            Console.Write("Nhap x: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            Y = double.Parse(Console.ReadLine());
        }

        public override string ToString() => $"({X}, {Y})";
    }

    // ============================================================
    // BÀI 2.2: Lớp Person + PersonList
    // ============================================================
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Yob { get; set; }

        public Person() { }
        public Person(int id, string name, int yob)
        {
            Id = id; Name = name; Yob = yob;
        }
        public Person(Person p)
        {
            Id = p.Id; Name = p.Name; Yob = p.Yob;
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

        public bool IsLiving() => Yob != 0;
    }

    class PersonList
    {
        private Person[] ds;
        public int N { get; set; }

        // Default constructor
        public PersonList()
        {
            N = 0;
            ds = new Person[0];
        }

        // Copy constructor
        public PersonList(PersonList other)
        {
            N = other.N;
            ds = new Person[N];
            for (int i = 0; i < N; i++)
                ds[i] = new Person(other.ds[i]);
        }

        // Indexer
        public Person this[int i]
        {
            get { return ds[i]; }
            set { ds[i] = value; }
        }

        public void Input()
        {
            Console.Write("Nhap so nguoi n: ");
            N = int.Parse(Console.ReadLine());
            ds = new Person[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap nguoi thu {i}:");
                ds[i] = new Person();
                ds[i].Input();
            }
        }

        public void Output()
        {
            Console.WriteLine("Danh sach Person:");
            foreach (Person p in ds)
                p.Output();
        }

        // Thêm 1 Person vào danh sách
        public void Add(Person x)
        {
            Array.Resize(ref ds, N + 1);
            ds[N] = x;
            N++;
        }

        // Trả về danh sách người còn sống
        public PersonList LivingPeople()
        {
            PersonList kq = new PersonList();
            foreach (Person p in ds)
            {
                if (p.IsLiving())
                    kq.Add(new Person(p));
            }
            return kq;
        }
    }

    // ============================================================
    // BÀI 2.3: Lớp DaySo (mảng 1 chiều số nguyên)
    // ============================================================
    class DaySo
    {
        private int[] a;
        public int N { get; set; }

        // a. Các constructor
        public DaySo()
        {
            N = 0;
            a = new int[0];
        }

        public DaySo(int n)
        {
            N = n;
            a = new int[n];
        }

        public DaySo(int[] arr)
        {
            N = arr.Length;
            a = (int[])arr.Clone();
        }

        public DaySo(DaySo other)
        {
            N = other.N;
            a = (int[])other.a.Clone();
        }

        // b. Indexer
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        // c. Nhập / Xuất
        public void Nhap()
        {
            Console.Write("Nhap so phan tu n: ");
            N = int.Parse(Console.ReadLine());
            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.Write("Day so: ");
            foreach (int x in a)
                Console.Write($"{x} ");
            Console.WriteLine();
        }

        // d. Tìm các số chẵn
        public DaySo TimSoChan()
        {
            int dem = 0;
            foreach (int x in a)
                if (x % 2 == 0) dem++;

            DaySo kq = new DaySo(dem);
            int j = 0;
            foreach (int x in a)
                if (x % 2 == 0)
                    kq[j++] = x;
            return kq;
        }
    }

    // ============================================================
    // BÀI 2.4: Lớp MaTran (mảng 2 chiều)
    // ============================================================
    class MaTran
    {
        private int[,] a;
        public int N { get; set; }
        public int M { get; set; }

        // a. Các constructor
        public MaTran()
        {
            N = 0; M = 0;
            a = new int[0, 0];
        }

        public MaTran(int n, int m)
        {
            N = n; M = m;
            a = new int[n, m];
        }

        public MaTran(MaTran other)
        {
            N = other.N; M = other.M;
            a = (int[,])other.a.Clone();
        }

        // b. Indexer cho mảng 2 chiều
        public int this[int i, int j]
        {
            get { return a[i, j]; }
            set { a[i, j] = value; }
        }

        // c. Nhập / Xuất
        public void Nhap()
        {
            Console.Write("Nhap n: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            M = int.Parse(Console.ReadLine());
            a = new int[N, M];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

        public void Xuat()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write($"{a[i, j],5}");
                Console.WriteLine();
            }
        }

        // d. Tìm số nguyên tố
        static bool LaNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0) return false;
            return true;
        }

        public void InSoNguyenTo()
        {
            Console.Write("Cac so nguyen to: ");
            foreach (int x in a)
                if (LaNguyenTo(x))
                    Console.Write($"{x} ");
            Console.WriteLine();
        }
    }

    // ============================================================
    // BÀI 2.3 (Đa thức): Lớp DaThuc
    // ============================================================
    class DaThuc
    {
        private double[] heSo;  // heSo[i] = a_i
        public int N { get; set; }  // bậc

        // a. Các constructor
        public DaThuc()
        {
            N = 0;
            heSo = new double[1];
        }

        public DaThuc(int n)
        {
            N = n;
            heSo = new double[n + 1];
        }

        public DaThuc(double[] a)
        {
            N = a.Length - 1;
            heSo = (double[])a.Clone();
        }

        public DaThuc(DaThuc other)
        {
            N = other.N;
            heSo = (double[])other.heSo.Clone();
        }

        // b. Indexer
        public double this[int i]
        {
            get { return heSo[i]; }
            set { heSo[i] = value; }
        }

        // c. Nhập / Xuất
        public void Nhap()
        {
            Console.Write("Nhap bac n: ");
            N = int.Parse(Console.ReadLine());
            heSo = new double[N + 1];
            for (int i = 0; i <= N; i++)
            {
                Console.Write($"Nhap he so a[{i}]: ");
                heSo[i] = double.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = N; i >= 0; i--)
            {
                if (heSo[i] == 0) continue;
                if (s != "" && heSo[i] > 0) s += " + ";
                else if (s != "" && heSo[i] < 0) s += " - ";

                double abs = Math.Abs(heSo[i]);
                if (i == 0) s += abs;
                else if (i == 1) s += $"{abs}x";
                else s += $"{abs}x^{i}";
            }
            return s == "" ? "0" : s;
        }

        // d. Tính giá trị đa thức tại x
        public double TinhGiaTri(double x)
        {
            double kq = 0;
            for (int i = 0; i <= N; i++)
                kq += heSo[i] * Math.Pow(x, i);
            return kq;
        }
    }

    // ============================================================
    // BÀI 2.4 (Dãy phân số): Lớp PhanSo + DayPhanSo
    // ============================================================
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo() { Tu = 0; Mau = 1; }
        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau == 0 ? 1 : mau;
        }

        public PhanSo(PhanSo p) { Tu = p.Tu; Mau = p.Mau; }

        public override string ToString() => $"{Tu}/{Mau}";

        public static PhanSo operator +(PhanSo a, PhanSo b)
            => new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
    }

    class DayPhanSo
    {
        private PhanSo[] ds;
        public int N { get; set; }

        public DayPhanSo(int n)
        {
            N = n;
            ds = new PhanSo[n];
        }

        public PhanSo this[int i]
        {
            get { return ds[i]; }
            set { ds[i] = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap so phan so n: ");
            N = int.Parse(Console.ReadLine());
            ds = new PhanSo[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap phan so thu {i}:");
                Console.Write("Tu: ");
                int tu = int.Parse(Console.ReadLine());
                Console.Write("Mau: ");
                int mau = int.Parse(Console.ReadLine());
                ds[i] = new PhanSo(tu, mau);
            }
        }

        public void Xuat()
        {
            Console.Write("Day phan so: ");
            foreach (PhanSo p in ds)
                Console.Write($"{p}  ");
            Console.WriteLine();
        }

        // Tổng của n phân số
        public PhanSo Tong()
        {
            PhanSo kq = new PhanSo(0, 1);
            foreach (PhanSo p in ds)
                kq = kq + p;
            return kq;
        }
    }

    // ============================================================
    // BÀI 2.5: Lớp NhanVien + PhongBan
    // ============================================================
    class NhanVien
    {
        public string HoTen { get; set; } = "";
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public NhanVien() { }
        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen;
            MucLuong = mucLuong;
            SoNgayVang = soNgayVang;
        }
        public NhanVien(NhanVien nv)
        {
            HoTen = nv.HoTen;
            MucLuong = nv.MucLuong;
            SoNgayVang = nv.SoNgayVang;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "";
            Console.Write("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        public double LuongThucNhan()
        {
            double luong = MucLuong - SoNgayVang * 100000;
            return luong < 0 ? 0 : luong;
        }

        public void Xuat()
        {
            Console.WriteLine($"{HoTen} | Luong: {MucLuong:N0} | Vang: {SoNgayVang} | Thuc nhan: {LuongThucNhan():N0}");
        }
    }

    class PhongBan
    {
        private NhanVien[] ds;
        public int N { get; set; }

        public PhongBan(int n)
        {
            N = n;
            ds = new NhanVien[n];
        }

        public NhanVien this[int i]
        {
            get { return ds[i]; }
            set { ds[i] = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap so nhan vien n: ");
            N = int.Parse(Console.ReadLine());
            ds = new NhanVien[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap nhan vien thu {i}:");
                ds[i] = new NhanVien();
                ds[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Danh sach nhan vien:");
            foreach (NhanVien nv in ds)
                nv.Xuat();
        }

        public double TongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in ds)
                tong += nv.LuongThucNhan();
            return tong;
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

            // ===== BÀI 2.1 =====
            Console.WriteLine("===== BÀI 2.1: ArrayPoint =====");
            ArrayPoint ap = new ArrayPoint(2);
            ap[0] = new Point(1, 2);
            ap[1] = new Point(3, 4);
            ap.Xuat();

            // ===== BÀI 2.2 =====
            Console.WriteLine("\n===== BÀI 2.2: PersonList =====");
            PersonList pl = new PersonList();
            pl.Add(new Person(1, "Nguyen Van A", 2005));
            pl.Add(new Person(2, "Tran Thi B", 0));     // yob = 0 (đã mất)
            pl.Add(new Person(3, "Le Van C", 1990));
            Console.WriteLine("Tat ca:");
            pl.Output();

            PersonList song = pl.LivingPeople();
            Console.WriteLine("Nguoi con song:");
            song.Output();

            // ===== BÀI 2.3 (DaySo) =====
            Console.WriteLine("\n===== BÀI 2.3: DaySo =====");
            DaySo d = new DaySo(new int[] { 3, 8, 5, 12, 7, 4 });
            d.Xuat();
            DaySo chan = d.TimSoChan();
            Console.Write("Cac so chan: ");
            chan.Xuat();

            // ===== BÀI 2.4 (MaTran) =====
            Console.WriteLine("\n===== BÀI 2.4: MaTran =====");
            MaTran mt = new MaTran(2, 3);
            mt[0, 0] = 2; mt[0, 1] = 7; mt[0, 2] = 4;
            mt[1, 0] = 9; mt[1, 1] = 11; mt[1, 2] = 6;
            mt.Xuat();
            mt.InSoNguyenTo();

            // ===== BÀI 2.3 (Đa thức) =====
            Console.WriteLine("\n===== BÀI 2.3: DaThuc =====");
            DaThuc dt = new DaThuc(new double[] { 1, 2, 3 });   // 3x^2 + 2x + 1
            Console.WriteLine($"Da thuc P(x) = {dt}");
            Console.WriteLine($"P(2) = {dt.TinhGiaTri(2)}");

            // ===== BÀI 2.4 (Dãy phân số) =====
            Console.WriteLine("\n===== BÀI 2.4: DayPhanSo =====");
            DayPhanSo dps = new DayPhanSo(3);
            dps[0] = new PhanSo(1, 2);
            dps[1] = new PhanSo(1, 3);
            dps[2] = new PhanSo(1, 6);
            dps.Xuat();
            Console.WriteLine($"Tong = {dps.Tong()}");

            // ===== BÀI 2.5 =====
            Console.WriteLine("\n===== BÀI 2.5: PhongBan =====");
            PhongBan pb = new PhongBan(3);
            pb[0] = new NhanVien("Nguyen Van A", 10000000, 2);
            pb[1] = new NhanVien("Tran Thi B", 8000000, 0);
            pb[2] = new NhanVien("Le Van C", 12000000, 3);
            pb.Xuat();
            Console.WriteLine($"Tong luong phong ban: {pb.TongLuong():N0} VND");
        }
    }
}