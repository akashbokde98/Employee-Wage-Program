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
            int totalWorkDays = 0;
            int dailyEmpWage = 0;
            int totalWorkHrs = 0;

            while ( (totalWorkDays <= 20) && (totalWorkHrs <= 100) ) 
            {
                switch ( rnd.Next(0, 3) )
                {
                    case 1:
                        int dailyWage = fullDayHr * wagePerHr;
                        dailyEmpWage += dailyWage;
                        totalWorkHrs += fullDayHr;
                        totalWorkDays++;
                        Console.WriteLine("Employee is Present and Wage is:" + dailyWage);
                        break;

                    case 2:
                        int partTimeWage = halfDayHr * wagePerHr;
                        dailyEmpWage += partTimeWage;
                        totalWorkHrs += halfDayHr;
                        totalWorkDays++;
                        Console.WriteLine("Employee is Present half Day and Wage is:" + partTimeWage);
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        break;
                }
            }
            Console.WriteLine("Total Working Day is:" + totalWorkDays);
            Console.WriteLine("Total Working Hours is:" + totalWorkHrs);
            Console.WriteLine("Wages for a Month is:" + dailyEmpWage);
        }
    }
}
