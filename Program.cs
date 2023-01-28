using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Random rnd = new Random();
            int isEmpPresent = rnd.Next(0, 2);

            int wagePerHr = 20;
            int fullDayHr = 8;

            if (isEmpPresent == 1)
            {
                int dailyEmpWage = fullDayHr * wagePerHr;
                Console.WriteLine("Employee is Present and Wage is:" + dailyEmpWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
