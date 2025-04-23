static int TinhTong(int a, int b)
{
    return a + b;
}
static void LoiChao(string name)
{
    Console.WriteLine("Xin chao: "+name);
}
//2. Khởi tạo
TinhToan tt = TinhTong;
HienThi ht = LoiChao;

//3. Thực thi
int kq = tt(3, 4);
Console.WriteLine("Ket qua: "+kq);
ht("Duoc");
//1. khai báo
public delegate int TinhToan(int x, int y);
public delegate void HienThi(string s); 
