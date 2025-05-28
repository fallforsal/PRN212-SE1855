using System.Text;

string ho = "Nguyễn";
String tenLot = "Thị";
String ten = "Tèo";
String fullName = ho + " " + tenLot + " " + ten;
Console.WriteLine(fullName);

StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenLot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString());