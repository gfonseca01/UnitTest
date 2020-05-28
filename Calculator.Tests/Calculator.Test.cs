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
        }

        [Fact]
        public void TestSubtract()
        {
        //Given
            var result = _calculator.Subtract(3,-1);
        //When
        
        //Then
            Assert.Equal(4,result);
        }

        [Fact]
        public void TestMultiply()
        {
        //Given
            var result = _calculator.Multiply(2,4);
        //When
        
        //Then
            Assert.Equal(8,result);
        }

        [Fact]
        public void TestDivide()
        {
        //Given
            var result = _calculator.Divide(5,2);
        //When
        
        //Then
            Assert.Equal(2.5,result);
        }
    }
}
