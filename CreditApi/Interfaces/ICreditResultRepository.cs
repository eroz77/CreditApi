using CreditApi.Models;

namespace CreditApi.Interfaces
{
    public interface ICreditResultRepository
    {
        CreditResult GetCreditResult(int appliedCreditAmount, int term, int preExistCreditAmount);
    }
}
