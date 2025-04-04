using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        Console.WriteLine("Nhập các phần tử:");
        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        SortArray(array);

        Console.WriteLine("Mảng đã sắp xếp theo thứ tự tăng dần:");
        foreach (double num in array)
        {
            Console.WriteLine(num);
        }
    }

    static void SortArray(double[] array)
    {
        Array.Sort(array);
    }
}
