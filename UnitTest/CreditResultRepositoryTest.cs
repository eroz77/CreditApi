using CreditApi.Repositories;
using Xunit;

namespace UnitTest
{
    public class CreditResultRepositoryTest
    {
        [Fact]
        public void GetCreditResult_Returns_A_Yes_Decision()
        {
            // Arrange
            var creditResultRepository = new CreditResultRepository();

            // Act
            var creditResult = creditResultRepository.GetCreditResult(15000, 6, 25000);

            // Assert
            Assert.Equal("Yes", creditResult.Decision);
        }

        [Fact]
        public void GetCreditResult_Returns_A_No_Decision()
        {
            // Arrange
            var creditResultRepository = new CreditResultRepository();

            // Act
            var creditResult = creditResultRepository.GetCreditResult(1000, 6, 25000);

            // Assert
            Assert.Equal("No", creditResult.Decision);
        }

        [Fact]
        public void GetCreditResult_Returns_A_Five_InterestRate()
        {
            // Arrange
            var creditResultRepository = new CreditResultRepository();

            // Act
            var creditResult = creditResultRepository.GetCreditResult(25000, 6, 30000);

            // Assert
            Assert.Equal(5, creditResult.InterestRatePct);
        }

        [Fact]
        public void GetCreditResult_Returns_Null()
        {
            // Arrange
            var creditResultRepository = new CreditResultRepository();

            // Act
            var creditResult = creditResultRepository.GetCreditResult(25000, 6, 35000);

            // Assert
            Assert.Null(creditResult);
        }
    }
}
