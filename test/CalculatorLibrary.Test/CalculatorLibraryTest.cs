using System;
using Xunit;
using CalculatorLibrary;

namespace CalculatorLibrary.Test
{
    public class CalculatorLibraryTest
    {
        [Fact]
        public void ShouldCreateCalculatorObject()
        {
            Calculator calculator = new Calculator();

            Assert.NotNull(calculator);

            calculator.Finish();
        }

        [Fact]
        public void ShouldBeSum()
        {
            Calculator calculator = new Calculator();
            double arg1 = 3.5;
            double arg2 = 2.5;
            Assert.Equal(arg1 + arg2, calculator.DoOperation(arg1, arg2, "a"));
        }

        [Fact]
        public void ShouldBeSubtract()
        {
            Calculator calculator = new Calculator();
            double arg1 = 3.5;
            double arg2 = 2.5;
            Assert.Equal(arg1 - arg2, calculator.DoOperation(arg1, arg2, "s"));
        }
        [Fact]
        public void ShouldBeMultiply()
        {
            Calculator calculator = new Calculator();
            double arg1 = 3.5;
            double arg2 = 2.5;
            Assert.Equal(arg1 * arg2, calculator.DoOperation(arg1, arg2, "m"));
        }
        [Fact]
        public void ShouldBeDivise()
        {
            Calculator calculator = new Calculator();
            double arg1 = 4;
            double arg2 = 2;
            Assert.Equal(arg1 / arg2, calculator.DoOperation(arg1, arg2, "d"));
        }
        
    }
}
