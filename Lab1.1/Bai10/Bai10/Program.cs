using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập một số: ");
        int number = int.Parse(Console.ReadLine());

        if (SNT(number))
        {
            Console.WriteLine($"{number} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số nguyên tố.");
        }
    }

    static bool SNT(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
