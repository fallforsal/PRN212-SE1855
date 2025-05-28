using System.Text;

namespace FullStruct
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;
            Console.WriteLine("Cha mẹ \"thói đời\" ăn ở bạc");
            Console.WriteLine("Có chồng cà chớn cũng như không");
            for(int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i]);
            }
            Console.ReadLine();
        }
    }
}