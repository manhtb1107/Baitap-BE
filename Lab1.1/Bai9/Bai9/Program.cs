using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập một số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            Console.WriteLine($"Giai thừa của {n} là: {TinhGiaiThua(n)}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
        }
    }

    static long TinhGiaiThua(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * TinhGiaiThua(n - 1);
    }
}
