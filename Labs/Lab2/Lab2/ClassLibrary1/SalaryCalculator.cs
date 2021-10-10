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

        const double ProvTax = 0.06;
        const double FedTax = 0.25;
        const double DependDeduct = 0.02;


        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            if (hourlyWage <= 0)
            { 
                throw new InvalidOperationException("Hourly wage must be greater than zero.");
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

        public TaxData TaxWithheld(double weeklySalary, int numDependents)
        {
            if (weeklySalary <= 0)
            {
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
            }
            if (numDependents < 0)
            {
                throw new InvalidOperationException("Number dependents cannot be negative.");
            }
            double pTaxed = weeklySalary * ProvTax;
            double fTaxed = weeklySalary * FedTax;
            double dDuct = weeklySalary * DependDeduct * numDependents;
            double withheld = pTaxed + fTaxed - dDuct;
            double take = weeklySalary - withheld;


            TaxData taxData = new TaxData(pTaxed, fTaxed, dDuct, withheld, take);

            return taxData;
        }


    }
}
