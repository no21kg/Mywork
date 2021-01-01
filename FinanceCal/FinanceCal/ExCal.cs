using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCal
{
    public class ExCal
    {
        private int _Result;
        private int _Interest;

        public int Result
        {
            get { return _Result; }
        }

        public int Interest
        {
            get { return _Interest; }
        }

        public void CalSaving(int Amount, double Rate, int Period, Tax TaxKind, Rate RateKind)
        {
            Rate = (double)(1 + Rate/100);
            double MonthRate = 0;
            int TempResult = 0;

            if (RateKind == FinanceCal.Rate.Simple)
            {
                MonthRate = 1.0 + (Rate - 1.0) / 12.0;
                TempResult = (int)(Period * (2.0 * Amount * MonthRate + (Period - 1.0) * Amount * (MonthRate - 1.0)) / 2.0);
            }
            else if(RateKind == FinanceCal.Rate.Compound)
            {
                MonthRate = Math.Pow(Rate, 1.0 / 12.0);
                TempResult = (int)(Amount * (Math.Pow(MonthRate, Period) - 1.0) / (MonthRate - 1.0));
            }

            int Principal = Amount * Period;
            int Interest = TempResult - Principal;


            CalTax(Interest, TaxKind);

            _Result = _Interest + Principal;
        }

        public void CalDeposit(int Amount, double Rate, int Period, Tax TaxKind, Rate RateKind)
        {
            Rate = (double)(1 + Rate / 100);
            double MonthRate = 0;
            int TempResult = 0;

            if (RateKind == FinanceCal.Rate.Simple)
            {
                MonthRate = Math.Pow(Rate, 1.0 / 12.0);
                TempResult = (int)(Amount * Math.Pow(MonthRate, Period));
            }
            else if (RateKind == FinanceCal.Rate.Compound)
            {
                MonthRate = (Rate - 1.0) / 12.0;
                TempResult = (int)(Amount * (1.0 + MonthRate));
            }

            int Principal = Amount;           
            int Interest = TempResult - Principal;


            CalTax(Interest, TaxKind);

             _Result = _Interest + Principal;
        }

        public void CalGoal(int Amount, double Rate, int Period, Tax TaxKind, Rate RateKind)
        {
            Rate = (double)(1 + Rate / 100);
            double MonthRate = 0;
            int TempResult = 0;
            double TaxRate = 0;

            if (TaxKind == Tax.Free)
            {
                TaxRate = 0.986;
            }
            else if (TaxKind == Tax.Premium)
            {
                TaxRate = 0.905;
            }
            else if (TaxKind == Tax.Normal)
            {
                TaxRate = 0.846;
            }

            if (RateKind == FinanceCal.Rate.Simple)
            {
                MonthRate = 1.0 + (Rate - 1.0) / 12.0;
                TempResult = (int)(Amount / (( (Period * (2.0 * MonthRate + (Period - 1.0) * (MonthRate - 1.0)) / 2) - Period) * TaxRate + Period));
            }
            else if (RateKind == FinanceCal.Rate.Compound)
            {
                MonthRate = Math.Pow(Rate, 1.0 / 12.0);
                TempResult = (int)(Amount  / (((Math.Pow(MonthRate, Period) - 1.0) / (MonthRate - 1.0) - Period) * TaxRate + Period));
            }

            _Result = TempResult;
        }

        private void CalTax(int Interest, Tax TaxKind)
        {
            if (TaxKind == Tax.Free)
            {
                Interest = (int)(Interest * 0.986);
            }
            else if (TaxKind == Tax.Premium)
            {
                Interest = (int)(Interest * 0.905);
            }
            else if (TaxKind == Tax.Normal)
            {
                Interest = (int)(Interest * 0.846);
            }

            _Interest = Interest;
        }
    }
}
