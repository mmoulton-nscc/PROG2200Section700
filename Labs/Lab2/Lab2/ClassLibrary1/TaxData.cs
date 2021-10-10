using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class TaxData
    {
        public double ProvincialTaxWithheld;
        public double FederalTaxWithheld;
        public double DependentDeduction;
        public double TotalWithheld;
        public double TotalTakeHome;

        public TaxData(double ptw, double ftw, double dd, double tw, double tth)
        {
            ProvincialTaxWithheld = ptw;
            FederalTaxWithheld = ftw;
            DependentDeduction = dd;
            TotalWithheld = tw;
            TotalTakeHome = tth;
        }
    }
}
