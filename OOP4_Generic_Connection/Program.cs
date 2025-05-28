using System.Text;
using OOP_2;

Console.OutputEncoding = Encoding.UTF8;
/*
 * Sử dụng Generic List để quản lý nhân sự
 * thực hiện đầy đủ tính năng CRUD
 * C-Create --> Thêm mới nhân sự
 * R->Read/Retrieve--> đọc : truy vấn, tìm kiếm , sắp xếp
 * U->Update-->chỉnh sửa dữ liệu
 * D-Delete-->
 */

//Câu 1 -C (Create)
// dùng list để tạo 5 Employee, trong đó 4 Employee là chính thức 
// và 1 Employee là thời vụ

List<Employee> employees = new List<Employee>();
FullTimeEmployee e1 = new FullTimeEmployee();
e1.Id = 1;
e1.Name = "Name 1";
e1.IdCard = "Card 1";
e1.Birthday = new DateTime(1993,11,29);
employees.Add(e1);
FullTimeEmployee e2 = new FullTimeEmployee();
e2.Id = 2;
e2.Name = "Name 2";
e2.IdCard = "Card 2";
e2.Birthday = new DateTime(1994, 5, 09);
employees.Add(e2);
FullTimeEmployee e3 = new FullTimeEmployee();
e3.Id = 3;
e3.Name = "Name 3";
e3.IdCard = "Card 3";
e3.Birthday = new DateTime(1995, 3, 19);
employees.Add(e3);
FullTimeEmployee e4 = new FullTimeEmployee();
e4.Id = 4;
e4.Name = "Name 4";
e4.IdCard = "Card 4";
e4.Birthday = new DateTime(1991, 10, 22);
employees.Add(e4);
PartTimeEmployee e5 = new PartTimeEmployee();
e5.Id = 5;
e5.Name = "Name 5";
e5.IdCard = "Card 5";
e5.Birthday = new DateTime(1983, 12, 30);
employees.Add(e5);
//Câu 2:R-> Xuất toàn bộ nhân sự
//Cách xuất 1:
Console.WriteLine("Danh sách nhân sự - cách 1-----");
employees.ForEach(e =>Console.WriteLine(e));
Console.WriteLine("Danh sách nhân sự - cách 2-----");
foreach (var e in employees)
    Console.WriteLine(e);

//Câu 3 : R-> lọc ra nhân sự chính thức và tính tổng lương
List<FullTimeEmployee> fe_list = employees.OfType<FullTimeEmployee>().ToList();
Console.WriteLine("-------Danh sách nhân sự chính thức------");
fe_list.ForEach(e => Console.WriteLine(e));
//Cách 2: dùng cách thông thường
List<FullTimeEmployee> fe_list2 = new List<FullTimeEmployee>();
foreach (var e in employees)
{
    if (e is FullTimeEmployee)
    fe_list2.Add(e as FullTimeEmployee);
}
Console.WriteLine("------Danh sách nhân sự chính thức cách 2---------");
fe_list2.ForEach(e => Console.WriteLine(e));

//Câu 4 : tính tổng lương
double sum_salary = fe_list2.Sum(e => e.CalSalary());
Console.WriteLine("Tổng lương = " +sum_salary);

for  (int i = 0; i < employees.Count; i++)
{
    for (int j = 0; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday > ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;  
        }
    }
}
Console.WriteLine("------Danh sách nhân sự chính thức đã sắp xếp ---------");
employees.ForEach(e => Console.WriteLine(e));
