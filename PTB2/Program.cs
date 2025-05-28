using System.Text;

namespace PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số c:");
            var c = double.Parse(Console.ReadLine());
            quadratic_equation_solution(a, b, c);
            Console.ReadLine
                ();
            
                void first_degree_solution(double a, double b)
                {
                    if (a == 0 && b == 0)
                    {
                        Console.WriteLine("Vô số nghiệm");

                    }
                    else if (a == 0 & b != 0)
                    {
                        Console.WriteLine("Vô Nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("x={0}", -b / a);
                    }

                }
                void quadratic_equation_solution(double a, double b, double c)
                {
                    if (a == 0)
                    {
                        first_degree_solution(b, c);
                    }
                    else
                    {
                        var delta = Math.Pow(b, 2) - 4 * a * c;
                        if (delta < 0)
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }
                        else if (delta == 0)
                        {
                            Console.WriteLine("Nghiệm kép x1=x2={0}", -b / (2 * a));
                        }
                        else
                        {
                            var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine("x1={0} , x2 ={1}", x1, x2);
                        }
                    }
                }
            }
        }    
    
}