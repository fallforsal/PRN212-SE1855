// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương trình bậc 1");
Console.WriteLine("Hệ số a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Hệ số b:");
double b = double.Parse(Console.ReadLine());

if(a==0 && b == 0)
{
    //0x+0=0
    Console.WriteLine("Phương trình vô số nghiệm");
} else if(a==0 && b!=0)
{
    Console.WriteLine("Phương trình vô nghiệm");
} else 
{
    Console.WriteLine($"Phương trình (ax+b=0) có nghiệm{-b/a}");
}
Console.ReadLine();
