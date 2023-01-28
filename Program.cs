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
            int monthDays = 20;
            int dailyEmpWage = 0;

            for (int day = 1; day <= monthDays; day++) 
            {
                switch ( rnd.Next(0, 3) )
                {
                    case 1:
                        int dailyWage = fullDayHr * wagePerHr;
                        dailyEmpWage += dailyWage;
                        Console.WriteLine("Employee is Present and Wage is:" + dailyWage);
                        break;

                    case 2:
                        int partTimeWage = halfDayHr * wagePerHr;
                        dailyEmpWage += partTimeWage;
                        Console.WriteLine("Employee is Present half Day and Wage is:" + partTimeWage);
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        break;
                }
            }
            Console.WriteLine("Wages for a Month is:" + dailyEmpWage);
        }
    }
}
