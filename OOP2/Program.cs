using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployee obama = new FullTimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 11, 25)
};
Console.WriteLine("--Thông tin của OBAMA--");
Console.WriteLine($"Id={obama.Id}");
Console.WriteLine($"Id Card={obama.IdCard}");
Console.WriteLine($"Name={obama.Name}");
Console.WriteLine($"Năm sinh=" +obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương ních ga nhận =" + obama.CalSalary());