Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.Write("Nhập nhiệt độ (độ C): ");
if (double.TryParse(Console.ReadLine(), out double C))
{
    double F = (C * 9 / 5) + 32;
    Console.WriteLine($"Nhiệt độ (độ F): {F}");
}
else
{
    Console.WriteLine("Giá trị nhập vào không hợp lệ.");
}