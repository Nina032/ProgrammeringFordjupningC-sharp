using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvEmployee
{
    public class Employee : Person
    {
        public string? EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public void WriteConsole()
        {
            Console.WriteLine(format: "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
                arg0: Name,
                arg1: DateofBirth,
                arg2: HireDate);
        }
    }
}
