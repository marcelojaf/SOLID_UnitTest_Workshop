using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class CalculationsTests
    {
        [Fact]
        [Trait("Category", "Simple Calculations")]
        public void Calculator_Addition_MustReturnCorrectResult()
        {
            Assert.Equal(10, Calculations.Addition(5, 5));
        }

        [Fact(DisplayName = "Subtraction")]
        [Trait("Category", "Simple Calculations")]
        public void Calculator_Subtraction_MustReturnCorrectResult()
        {
            Assert.Equal(0, Calculations.Subtraction(5, 5));
        }

        [Fact]
        [Trait("Category", "Simple Calculations")]
        public void Calculator_Multiplication_MustReturnCorrectResult()
        {
            Assert.Equal(25, Calculations.Multiplication(5, 5));
        }

        [Fact(DisplayName = "Division")]
        [Trait("Category", "Simple Calculations")]
        public void Calculator_Division_MustReturnCorrectResult()
        {
            Assert.Equal(1, Calculations.Division(5, 5));
        }

        [Fact(DisplayName = "Division by zero")]
        [Trait("Category", "Error situations")]
        public void Calculator_DivisionByZero_MustReturnException()
        {
            var exception = Assert.Throws<DivideByZeroException>(() => Calculations.Division(3, 1));
            Assert.Equal("Attempted to divide by zero.", exception.Message);
        }
    }
}
