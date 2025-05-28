using System.Text;
using OOP_2;
using OOP2_ReUse_AS_LIB;

Console.OutputEncoding = Encoding.UTF8;
FullTimeEmployee e1= new FullTimeEmployee();
e1.Id = 1;
e1.Name = "Mẹ m";
e1.IdCard = "123";
e1.Birthday = new DateTime(1888,12,25);
Console.WriteLine("Thông tin");
Console.WriteLine(e1);
Console.WriteLine("Tuổi:" + e1.TinhTuoi());