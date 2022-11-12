using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 8, PART_TIME = 1;
        public void Attendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Abesnt");
            }
        }

        public void DailyWage()
        {
            int empHrs = 0;
            int Empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);

            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee is Absent");
                empHrs = 0;
            }

            Empwage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Employee salary is :" + Empwage);
        }

        public void PartTime()
        {
            int empHrs = 0;
            int Empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (empcheck == IS_PART_TIME)
            {
                Console.WriteLine("employee is PartTime");
                empHrs = 8;
            }

            else
            {
                Console.WriteLine("employee is Absent");
                empHrs = 0;
            }

            Empwage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Employee salary is :" + Empwage);
        }
    }
}
