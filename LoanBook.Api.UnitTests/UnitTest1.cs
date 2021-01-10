using System;
using Xunit;

namespace LoanBook.Api.UnitTests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSumOfNumbers()
        {
            var stringCalculator = CreateDefaultStringCalculator();

            var actual = stringCalculator.Add("0,1");

            Assert.Equal(1, actual);
        }

        // more tests...

        private StringCalculator CreateDefaultStringCalculator()
        {
            return new StringCalculator();
        }

        private class StringCalculator
        {
            public StringCalculator()
            {
            }

            internal object Add(string v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
