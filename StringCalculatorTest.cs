using System;
using Xunit;

namespace HsbcCodingDojo
{
    public class StringCalculatorTest
    {
        private StringCalculator cal = new StringCalculator();

        [Fact]
        public void testEmptyString ()
        {
            Assert.Equal(0, cal.Add(String.Empty));
        }
    }
}