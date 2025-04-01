using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vào một năm: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{year} không phải là năm nhuận.");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
