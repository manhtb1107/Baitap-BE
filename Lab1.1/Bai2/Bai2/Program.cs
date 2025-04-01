Console.OutputEncoding = System.Text.Encoding.UTF8;

float chieuDai, chieuRong;

Console.Write("Nhập chiều dài: ");
chieuDai = float.Parse(Console.ReadLine());
Console.Write("Nhập Chiều rộng: ");
chieuRong = float.Parse(Console.ReadLine());

float dientichHCN = chieuDai * chieuRong;
Console.Write("Diện tích hình chữ nhật là: "+dientichHCN);