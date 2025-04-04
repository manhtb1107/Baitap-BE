using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Các phần tử là số nguyên tố trong mảng:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(mang[i]))
            {
                Console.WriteLine($"Chỉ số: {i}, Giá trị: {mang[i]}");
            }
        }
    }

    static bool LaSoNguyenTo(int so)
    {
        if (so < 2) return false;
        for (int i = 2; i <= Math.Sqrt(so); i++)
        {
            if (so % i == 0) return false;
        }
        return true;
    }
}
