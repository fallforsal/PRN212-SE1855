using OOP1;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//tao 1 doi tuong danh muc
Category c1 = new Category();
//Gan gia tri cho thuoc tinh
c1.Id = 1;
    c1.Name = "Nuoc mam";
//Goi ham xuat du lieu
c1.PrintInfor();

//khoi tao nhan vien

Employee e1 = new Employee();
e1.Id = 1; //goi setter Id
e1.Id_card = "00123"; //gei setter property Id_card
e1.Name = "teo";
e1.Email = "teo@gmail.com";
e1.Phone = "0365482281";
//goi ham xuat thong tin
e1.PrintInfor();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Id cua e1=" + e1.Id);
Console.WriteLine("name cua e1=" + e1.Name);
Employee e2 = new Employee()
{
    Id = 2,
    Id_card = "jsjsjsjsjsjsj",
    Name = "Thiểu năng trí tuệ",
    Email  ="thieunang@gmail.com",
    Phone = " 0920392039239",
    
};
Console.WriteLine("------------------------------");
e2.PrintInfor();

Console.WriteLine("-----------------------------");
Employee e3 = new Employee(3,"0009","Trí tuệ","tri@gmail.com","09582585285");
e3.PrintInfor();
Console.WriteLine(e3);

Customer cus1 = new Customer()
{
       id = 1,
       name = "Thiểu năng trí tuệ",
       phone="0902930923",
       email="kkk@gmail.com",
       address="2323",
};
cus1.PrintInfor();
cus1.address = "3232";
    cus1.phone = "8338338383";
    Console.WriteLine("Thông tin ");
cus1.PrintInfor();