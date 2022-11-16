namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendence();

            EmployeeWage employeeWage1 = new EmployeeWage();
            employeeWage.DailyWage();

            EmployeeWage employeeWage2 = new EmployeeWage();
            employeeWage2.PartTime();

            EmployeeWage employeeWage3 = new EmployeeWage();
            employeeWage3.SwitchCase();

            EmployeeWage employeeWage4 = new EmployeeWage();
            employeeWage4.MonthlyWage();

            EmployeeWage employeeWage5 = new EmployeeWage();
            employeeWage5.WorkingHrs();

            EmployeeWage employeeWage6 = new EmployeeWage();
            employeeWage6.ComputeEmpWage();

            EmployeeWage employeeWage7 = new EmployeeWage();
            employeeWage7.Multiple();
        }
    }
}