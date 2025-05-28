using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class PartTimeEmployee : Employee
    {
        public int WorkingHour { get; set; }
        public override double CalSalary()
        {
            return 100000 + WorkingHour;
        }
    }
}
