using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWageCompute
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC1 -EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 2);//0 or 1
            if (empAttendence == isPresent)
            {
                Console.WriteLine("employee is Present");
            }
            else
            {
                Console.WriteLine("employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
