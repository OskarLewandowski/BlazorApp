using Library.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    public class ImperialBmiCalculatorTests
    {
        [Theory]
        [InlineData(100, 170, 2.43)]
        [InlineData(57, 170, 1.39)]
        [InlineData(70, 170, 1.7)]
        [InlineData(77, 160, 2.11)]
        [InlineData(80, 190, 1.56)]
        [InlineData(90, 190, 1.75)]
        public void CalculateBmi_ForGivenWeightAndHeight_ReturnsCorrectBmi(double weight, double height, double bmiResult)
        {
            //arrange
            ImperialBmiCalculator imperialBmiCalculator = new ImperialBmiCalculator();

            //act
            double result = imperialBmiCalculator.CalculateBmi(weight, height);

            //assert

            Assert.Equal(bmiResult, result);

        }
    }
}
