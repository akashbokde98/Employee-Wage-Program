using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Random rnd = new Random();
            int isEmpPresent = rnd.Next(0, 3);

            int wagePerHr = 20;
            int fullDayHr = 8;
            int halfDayHr = 4;

            switch (isEmpPresent)
            {
                case 1:
                    int dailyEmpWage = fullDayHr * wagePerHr;
                    Console.WriteLine("Employee is Present and Wage is:" + dailyEmpWage);
                    break;
            
                case 2:
                    int partTimeEmpWage = halfDayHr * wagePerHr;
                    Console.WriteLine("Employee is Present half Day and Wage is:" + partTimeEmpWage);
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
