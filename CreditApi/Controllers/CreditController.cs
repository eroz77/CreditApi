using CreditApi.Interfaces;
using CreditApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreditApi.Controllers
{
    /// <summary>
    /// Rest controller for handling request
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CreditController : ControllerBase
    {
        private readonly ICreditResultRepository _repository;

        public CreditController(ICreditResultRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Returns a credit result (decision and interest rate percentage) 
        /// </summary>
        [HttpGet("/GetCreditResult/{appliedCreditAmount}/{term}/{preExistCreditAmount}")]
        public ActionResult<CreditResult> GetCreditResult(int appliedCreditAmount, int term, int preExistCreditAmount)
        {
            var creditResult = _repository.GetCreditResult(appliedCreditAmount, term, preExistCreditAmount);

            if (creditResult == null)
            {
                return NotFound();
            }

            return Ok(creditResult);
        }   
    }
}
