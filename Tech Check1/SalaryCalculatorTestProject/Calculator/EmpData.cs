using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class EmpData
    {

        //Mark Moulton W0440932

        public double TaxAmount;
        public double DependentDeduction;
        public double NetTaxAmount;
        public double TotalTakeHome;

        public EmpData(double tax, double dd, double tw, double tth)
        {
            TaxAmount = tax;
            DependentDeduction = dd;
            NetTaxAmount = tw;
            TotalTakeHome = tth;
        }
    }
}
