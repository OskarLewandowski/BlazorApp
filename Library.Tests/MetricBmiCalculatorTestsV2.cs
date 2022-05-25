using Library.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    public class MetricBmiCalculatorTestsV2
    {
        public static IEnumerable<object[]> GetSampleData()
        {
            yield return new object[] { 100, 170, 34.6 };
            yield return new object[] { 57, 170, 19.72 };
            yield return new object[] { 70, 170, 24.22 };
            yield return new object[] { 77, 160, 30.08 };
            yield return new object[] { 80, 190, 22.16 };
            yield return new object[] { 90, 190, 24.93 };
        }

        [Theory]
        [MemberData(nameof(GetSampleData))]
        public void CalculateBmi_ForGivenWeightAndHeight_ReturnsCorrectBmi(double weight, double height, double bmiResult)
        {
            //arrange
            MetricBmiCalculator metricBmiCalculator = new MetricBmiCalculator();

            //act
            double result = metricBmiCalculator.CalculateBmi(weight, height);

            //assert

            Assert.Equal(bmiResult, result);

        }
    }
}
