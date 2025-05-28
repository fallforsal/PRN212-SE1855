using System.Text;
using OOP3_ExtensionMethod;

Console.OutputEncoding = Encoding.UTF8;
int n1 = 5;
Console.WriteLine("Tổng từ 1 tới 5=" + n1.TongTu1toN());
int n2 = 10;
Console.WriteLine("Tổng từ 1 tới 10=" + n2.TongTu1toN());
Console.WriteLine("Tổng từ 1 tới 100=" + 100.TongTu1toN());

Console.WriteLine("10+20=" + 10.Cong(20));
int[] arr = new int[5];
arr.TaoMang();
Console.WriteLine("Mảng trước khi sắp xếp:");
arr.XuatMang();
arr.SapXepTangDan();
Console.WriteLine("Mảng sau khi sắp xếp:");
arr.XuatMang();