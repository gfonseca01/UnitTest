using System;
using Xunit;
using Services;

namespace Tests
{
    public class Test
    {
        private readonly Calculator _calculator;
        public Test() {
            _calculator = new Calculator();
        }

        [Fact]
        public void TestAdd()
        {
             var result = _calculator.Add(1,1);
             Assert.Equal(2, result);
             Assert.Equal(5,_calculator.Add(6,-1));
        }

        [Theory]
        [InlineData(8,3,5)]
        [InlineData(-1,-2,1)]
        [InlineData(5,-2,7)]
        [InlineData(-7,2,-9)]
        public void TestSubtract(int value1, int value2, int expected)
        {
            var result = _calculator.Subtract(value1,value2);
            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData(3,5,15)]
        [InlineData(10,0,0)]
        [InlineData(-3,2,-6)]
        [InlineData(-5,-2,10)]
        public void TestMultiply(int value1, int value2, int expected)
        {
            var result = _calculator.Multiply(value1,value2);
            Assert.Equal(expected,result);
        }

        [Fact]
        public void TestDivide()
        {
            var result = _calculator.Divide(5,2);
            Assert.Equal(2.5,result);
        }
    }
}
