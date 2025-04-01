Console.OutputEncoding = System.Text.Encoding.UTF8;

float a, b;
Console.Write("Nhập a : ");
a = float.Parse(Console.ReadLine());
Console.Write("Nhập b : ");
b = float.Parse(Console.ReadLine());
float tong = a + b;
float tich = a * b;
Console.WriteLine($"Tổng ={tong}, Tích = {tich}");