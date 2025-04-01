Console.OutputEncoding = System.Text.Encoding.UTF8;

int x;

Console.Write("Nhập 1 số nguyên: ");
x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine($"{x} Là số nguyên ");

}
else
{
    Console.WriteLine($"{x} Là số lẻ ");
}