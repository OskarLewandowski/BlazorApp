using Library.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    public class MetricBmiCalculatorTests
    {
        [Theory]
        [InlineData(100, 170, 34.6)]
        [InlineData(57, 170, 19.72)]
        [InlineData(70, 170, 24.22)]
        [InlineData(77, 160, 30.08)]
        [InlineData(80, 190, 22.16)]
        [InlineData(90, 190, 24.93)]
        public void CalculateBmi_ForGivenWeightAndHeight_ReturnsCorrectBmi(double weight, double height, double bmiResult)
        {
            //arrange
            MetricBmiCalculator metricBmiCalculator = new MetricBmiCalculator();

            //act
            double result = metricBmiCalculator.CalculateBmi(weight, height);

            //assert

            Assert.Equal(bmiResult, result);

        }


        [Theory]
        [ClassData(typeof(MetricBmiCalculatorTestsData))]
        public void CalculateBmi_ForInvalidArguments_ThrowsArgumentsException(double weight, double height)
        {
            //arrange
            MetricBmiCalculator metricBmiCalculator = new MetricBmiCalculator();

            //act
            //we create a delegate
            Action action = () => metricBmiCalculator.CalculateBmi(weight, height);

            //assert
            //            we need the same type ArgumentException
            Assert.Throws<ArgumentException>(action);
        }
    }
}
