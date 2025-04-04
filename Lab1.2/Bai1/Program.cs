using System;
using System.Linq;
using System.Text;

class Program
{

    static void Main(string[] args)
    {   
        Console.OutputEncoding = Encoding.UTF8;
        int[] so = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int tong = TongSoChan(so);
        Console.WriteLine($"Tổng các số chẵn: {tong}");
    }

    static int TongSoChan(int[] so)
    {
        return so.Where(n => n % 2 == 0).Sum();
    }
}
