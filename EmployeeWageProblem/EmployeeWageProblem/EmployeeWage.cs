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
        int empHrs = 0, EmpHrs = 0, totalWorkingDays = 0, salary = 0;
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

            salary = empHrs * WAGE_PER_HR;
            Console.WriteLine("Employee salary is :" + salary);
        }

        public void PartTime()
        {
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

            salary = empHrs * WAGE_PER_HR;
            Console.WriteLine("Employee salary is :" + salary);
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
            salary = WAGE_PER_HR * empHrs;
            Console.WriteLine("Monthly salary is: " + salary);
        }

        public void WorkingHrs()
        {
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
        public int Multiple()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            while (totalWorkingDays < WORKING_DAYS && empHrs < HOUR_IN_MONTH)
            {
                totalWorkingDays = totalWorkingDays + 1;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += IS_FULL_TIME;
                        break;
                    case IS_PART_TIME:
                        empHrs += IS_PART_TIME;
                        break;

                    default:
                        empHrs += 0;
                        break;
                }
            }
            Console.WriteLine("Working Hours : " + empHrs + ", Working Days : " + WORKING_DAYS);
            salary = empHrs * WAGE_PER_HR;

            Console.WriteLine("Total Employee Salary of " + WORKING_DAYS + " Day is : " + salary + "\n");
            return salary;
        }
        public void ClassMethod()
        {
            while (EmpHrs <= HOUR_IN_MONTH && totalWorkingDays < WORKING_DAYS)
            {
                
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs += 0;
                        break;
                }
            }
            EmpHrs = empHrs;
            salary = EmpHrs * WAGE_PER_HR;
            Console.WriteLine("Day: " + WORKING_DAYS + "Emp Hr: " + EmpHrs);
        }
    }
}
