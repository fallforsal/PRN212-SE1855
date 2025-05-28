using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_2;

namespace OOP2_ReUse_AS_LIB
{
    public static class YourMum
    {
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year + 1;
        }
    }
}
