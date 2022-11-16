using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 8, PART_TIME = 1, HOUR_IN_MONTH = 100, WORKING_DAYS = 20;
        int empHrs = 0, EmpHrs = 0, totalWorkingDays = 0;
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

        public void SwitchCase()
        {
            int empHrs = 0;
            int totalEmpWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 1:
                    empHrs = IS_FULL_TIME;
                    Console.WriteLine("Employee is Present");
                    break;

                case 2:
                    empHrs = IS_PART_TIME;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Total Employee salary is: " + totalEmpWage);
        }

        public void MonthlyWage()
        {
            int empHrs = 0;
            int totalEmpWage = 0;

            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_TIME_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                }
            }
            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Monthly salary is: " + totalEmpWage);
        }

        public void WorkingHrs()
        {
            int empHrs = 0;
            int salary = 0;

            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS && empHrs < 100; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_TIME_HR;
                        break;

                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                }
            }
            salary = WAGE_PER_HR * empHrs;
            Console.WriteLine("Total Employee salary is: " + salary);
        }
        public void ComputeEmpWage()
        {
            while (EmpHrs <= HOUR_IN_MONTH && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                empHrs++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                EmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "\nEmployee Working Hours: " + empHrs);

                int empWage = EmpHrs * WAGE_PER_HR;
                Console.WriteLine("Total Employee Wage: " + empWage);

            }
        }
    }
}
