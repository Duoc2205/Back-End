using Hoc_GenericCollections;

int? x = null; // ? cho phép chứa null
Console.WriteLine("x = " + x);


//1. List<T>: Tương tự như Arraylist, nhưng phải xđ
//Kiểu dữ liệu trước cho các ptu
//List<string> list = new List<string>();
//list.Add("Tram");
//list.Add("Thao");
//list.Add("Linh");
// Các phương thức tương tự như Arraylist

//Có thể viết ngắn gọn như sau:
List<string> list = new List<string>()
{
    "Tram", "Thao", "Linh"
};

//List<KhachHang> lisKH = new List<KhachHang>();
//lisKH.Add(new KhachHang() { MaKH = 1, HoTen = "Ngoc T"});
//lisKH.Add(new KhachHang() { MaKH = 2, HoTen = "Ngoc B" });

//Có thể viết ngắn gọn như sau
List


//2. Dictionary<K, V>: Tương tự như hastable nhwngg K và V phải xđ kiểu dl trước
Dictionary<int, string> dic = new Dictionary<int, string>();
dic.Add(1, "Trung");
dic.Add(2, "Dat"); 