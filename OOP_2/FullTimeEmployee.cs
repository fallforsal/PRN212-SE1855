using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class FullTimeEmployee : Employee
    {
        public override double CalSalary()
        {
            return base.CalSalary() + 5000000;
        }
    }
}
