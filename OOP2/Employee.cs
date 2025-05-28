using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; }

        public DateTime Birthday { get; set; }

        public virtual double CalSalary()
        {
            return 4000000;
        }

    }
}
