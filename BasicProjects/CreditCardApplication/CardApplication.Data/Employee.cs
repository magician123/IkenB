using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication.Data
{
    public class Employee
    {
        public long ApplicationNumber { get; set; }
        public double Salary { get; set; }
        public double Rent { get; set; }
        public int YearsEmployed { get; set; }
        public int YearsResiding { get; set; }
    }
}
