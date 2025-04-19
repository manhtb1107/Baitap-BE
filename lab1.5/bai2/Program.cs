using System;
using System.Collections.Generic;

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public override double TinhChuVi()
    {
        return 4 * Canh;
    }

    public override double TinhDienTich()
    {
        return Canh * Canh;
    }
}

class HinhTamGiac : Hinh
{
    public double CanhA { get; set; }
    public double CanhB { get; set; }
    public double CanhC { get; set; }

    public HinhTamGiac(double canhA, double canhB, double canhC)
    {
        CanhA = canhA;
        CanhB = canhB;
        CanhC = canhC;
    }

    public override double TinhChuVi()
    {
        return CanhA + CanhB + CanhC;
    }

    public override double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
    }
}

class HinhChuNhat : Hinh
{
    public double ChieuDai { get; set; }
    public double ChieuRong { get; set; }

    public HinhChuNhat(double chieuDai, double chieuRong)
    {
        ChieuDai = chieuDai;
        ChieuRong = chieuRong;
    }

    public override double TinhChuVi()
    {
        return 2 * (ChieuDai + ChieuRong);
    }

    public override double TinhDienTich()
    {
        return ChieuDai * ChieuRong;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Hinh> danhSachHinh = new List<Hinh>
        {
            new HinhTron(5),
            new HinhVuong(4),
            new HinhTamGiac(3, 4, 5),
            new HinhChuNhat(6, 3)
        };

        double tongChuVi = 0;
        double tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            tongChuVi += hinh.TinhChuVi();
            tongDienTich += hinh.TinhDienTich();
        }

        Console.WriteLine($"Tổng chu vi: {tongChuVi}");
        Console.WriteLine($"Tổng diện tích: {tongDienTich}");
    }
}
