using System;
using System.Collections.Generic;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
            throw new ArgumentException("Mẫu số không được bằng 0.");
        TuSo = tuSo;
        MauSo = mauSo;
        Simplify();
    }

    public void NhapPhanSo()
    {
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());
        if (MauSo == 0)
            throw new ArgumentException("Mẫu số không được bằng 0.");
        Simplify();
    }

    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int mau = a.MauSo * b.MauSo;
        return new PhanSo(tu, mau);
    }

    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }

    private void Simplify()
    {
        int gcd = GCD(Math.Abs(TuSo), Math.Abs(MauSo));
        TuSo /= gcd;
        MauSo /= gcd;
        if (MauSo < 0)
        {
            TuSo = -TuSo;
            MauSo = -MauSo;
        }
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

class Program
{
    static void Main()
    {
        List<PhanSo> danhSachPhanSo = new List<PhanSo>();
        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phân số thứ {i + 1}:");
            PhanSo phanSo = new PhanSo(0, 1);
            phanSo.NhapPhanSo();
            danhSachPhanSo.Add(phanSo);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var phanSo in danhSachPhanSo)
        {
            tong = PhanSo.Cong(tong, phanSo);
        }

        Console.WriteLine($"Tổng các phân số: {tong}");
    }
}
