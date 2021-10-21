using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

        const double Tax = 0.25;
        const double DependDeduct = 0.05;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            if (hourlyWage <= 0)
            {
                throw new InvalidOperationException("Hourly wage must not be less than zero.");
            }
            return hourlyWage* HoursInYear; 
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly salary must be greater than zero.");
            }
            return annualSalary / HoursInYear;
        }

        public EmpData EmpAccount(double weeklySalary, int numDependents)
        {
            if (weeklySalary <= 0)
            {
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
            }
            if (numDependents < 0)
            {
                throw new InvalidOperationException("Number dependents cannot be negative.");
            }
            double Taxed = weeklySalary * Tax;
            double dDuct = weeklySalary * DependDeduct * numDependents;
            double withheld = Taxed - dDuct;
            double take = weeklySalary - withheld;


            EmpData empData = new EmpData(Taxed, dDuct, withheld, take);

            return empData;
        }

    }
}
