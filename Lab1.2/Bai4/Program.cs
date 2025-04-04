using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        int[] numbers = { 1, 3, 4, 5, 0, 2 };
        int secondLargest = TimSoLonThuHai(numbers);
        Console.WriteLine("Số lớn thứ hai là: " + secondLargest);
    }

    static int TimSoLonThuHai(int[] numbers)
    {
        if (numbers == null || numbers.Length < 2)
        {
            throw new ArgumentException("Mảng phải chứa ít nhất hai phần tử.");
        }

        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > first)
            {
                second = first;
                first = number;
            }
            else if (number > second && number != first)
            {
                second = number;
            }
        }

        return second;
    }
}
