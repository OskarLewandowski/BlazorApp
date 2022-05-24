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


        [Theory]
        [InlineData(0, 190)]
        [InlineData(-5, 150)]
        [InlineData(-11, 150)]
        [InlineData(90, -150)]
        [InlineData(90, 0)]
        [InlineData(0, 0)]
        public void CalculateBmi_ForInvalidArguments_ThrowsArgumentsException(double weight, double height)
        {
            //arrange
            ImperialBmiCalculator imperialBmiCalculator = new ImperialBmiCalculator();

            //act
            //we create a delegate
            Action action = () => imperialBmiCalculator.CalculateBmi(weight, height);

            //assert
            //            we need the same type ArgumentException
            Assert.Throws<ArgumentException>(action);
        }
    }
}
