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
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
                
            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC3 -EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 3);//0 or 1 or 2
            if (empAttendence == FULL_TIME)
            {
                Console.WriteLine("Full Time employee is Present");
                empHrs = 8;
            }
            else if(empAttendence == PART_TIME)
            {
                Console.WriteLine("Part Time employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage:{0}", empWage);
            Console.ReadLine();
        }
    }
}
