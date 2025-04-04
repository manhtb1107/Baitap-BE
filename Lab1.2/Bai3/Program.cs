using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        (int soDuong, int soAm) = DemSoDuongVaSoAm(array);

        Console.WriteLine($"Số lượng số dương: {soDuong}");
        Console.WriteLine($"Số lượng số âm: {soAm}");
    }

    static (int soDuong, int soAm) DemSoDuongVaSoAm(int[] array)
    {
        int soDuong = 0;
        int soAm = 0;

        foreach (int number in array)
        {
            if (number > 0)
            {
                soDuong++;
            }
            else if (number < 0)
            {
                soAm++;
            }
        }

        return (soDuong, soAm);
    }
}
