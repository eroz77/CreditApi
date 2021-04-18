using CreditApi.Interfaces;
using CreditApi.Models;
using System;

namespace CreditApi.Repositories
{
    public class CreditResultRepository : ICreditResultRepository
    {
        public CreditResult GetCreditResult(int appliedCreditAmount, int term, int preExistCreditAmount)
        {
            string decision;
            int interestRatePct;
            int totalFutureDebt = appliedCreditAmount + preExistCreditAmount; 

            // Get decision
            if (appliedCreditAmount < 2000 || appliedCreditAmount > 69000)
                decision = "No";
            else if (appliedCreditAmount > 2000)
                decision = "Yes";
            else
                // If appliedCreditAmount = 2000
                return null;

            // Get interest rate percentage
            if (totalFutureDebt < 20000)
                interestRatePct = 3;
            else if (totalFutureDebt >= 20000 && totalFutureDebt <= 39000)
                interestRatePct = 4;
            else if (totalFutureDebt >= 40000 && totalFutureDebt <= 59000)
                interestRatePct = 5;
            else if (totalFutureDebt > 60000)
                interestRatePct = 6;
            else
                // If totalFutureDebt between 39001 and 39999 or between 59001 and 60000
                return null;

            return new CreditResult() { Decision = decision, InterestRatePct = interestRatePct };
        }
    }
}
