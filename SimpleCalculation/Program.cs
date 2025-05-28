// See https://aka.ms/new-console-template for more information
void do_calculation(double a, double b,String op)
{
    switch (op)
    {
        case "+":
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            break;
        case "-":
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            break;
        default:
            Console.WriteLine("oc cac nao tan");
            break;
    }
    
}
Console.WriteLine("Simple calculation");
Console.WriteLine("Nhap so a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap so b:");
double b = double.Parse(Console.ReadLine());
String op = Console.ReadLine();
do_calculation(a, b, op);
Console.ReadLine();

