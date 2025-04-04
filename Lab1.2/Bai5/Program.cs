
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên thứ nhất (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên thứ hai (b): ");
        int b = int.Parse(Console.ReadLine());

        HoanVi(ref a, ref b);

        Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
        Console.ReadKey();
    }
    
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
   
}
