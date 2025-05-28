using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Customer
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        
        public string address {  get; set; }
        public void PrintInfor()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Customer ID = {id}");
            Console.WriteLine($"Customer name = {name}");
            Console.WriteLine($"Customer email = {email}");
            Console.WriteLine($"Customer phone = {phone}");
            Console.WriteLine($"Customer address = {address}");
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
            
        }
            
          
    }
}
