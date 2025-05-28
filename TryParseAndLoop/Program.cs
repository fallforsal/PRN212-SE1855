/* Đề bài: 
 * Nhập vào 1 số lớn hơn hoặc bằng 0 , nếu sai bắt nhập lai
 * Nếu nhập đúng thì tính giai thừa của số này
 */
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int n = -1;
while ( n < 0)
{
    Console.WriteLine("Nhập N lớn hơn hoặc bằng 0");
   String input = Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    { //khi vào đây thì n là số , nhưng có thể = 0;
        if (n >= 0)
            break;
        else
            Console.WriteLine("Thằng ngu");
        continue;
    }
    else
    {
        Console.WriteLine("Số mà cái địt mẹ m");
        continue;
    }
   
}
int gt = 1;
for (int i = 1; i <= n; i++)
    gt = gt * 1;
Console.WriteLine($"{n}!={gt}");