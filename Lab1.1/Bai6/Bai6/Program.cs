Console.OutputEncoding = System.Text.Encoding.UTF8;

float x;

Console.Write("Nhập x: ");
x = float.Parse(Console.ReadLine() ?? "0");
if (x > 0)
{
    Console.WriteLine($"{x} Là số dương");
}
else if ( x == 0)
{
    Console.WriteLine($"{x} : Không là số dương hay âm");
}
else
{
    Console.WriteLine($"{x} Là số âm");
}
