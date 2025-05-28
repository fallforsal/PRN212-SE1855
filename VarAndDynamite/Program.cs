namespace VarAndDynamite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            Console.WriteLine(x);
            dynamic y = "0";
            Console.WriteLine(y);
            y = "012345";
            Console.WriteLine(y);
            y = new DateTime().Day;
            Console.WriteLine(y);   
        }
    }
}