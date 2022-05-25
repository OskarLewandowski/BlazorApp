using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit.Abstractions;

namespace Library.Tests
{
    public class BmiCalculatorFacadeTests
    {

        public BmiCalculatorFacadeTests(ITestOutputHelper testOutputHelper)
        {
            _outputHelper = testOutputHelper;
        }

        private readonly ITestOutputHelper _outputHelper;

        private const string OBESITY_SUMARRY = "You should take care of your obesity";
        private const string NORMAL_SUMARRY = "Your weight is normal, keep it up";
        private const string OVERWEIGHT_SUMARRY = "You are a bit overweight";

        [Theory]
        [InlineData(BmiClassification.Obesity, OBESITY_SUMARRY)]
        [InlineData(BmiClassification.Normal, NORMAL_SUMARRY)]
        [InlineData(BmiClassification.Overweight, OVERWEIGHT_SUMARRY)]
        public void GetResult_ForValidInputs_ReturnsCorrectSummary(BmiClassification classification, string summary)
        {
            //arrange
            //IBmiDeterminator bmiDeterminator = new BmiDeterminator();
            //bmiDeterminator.DetermineBmi(bmi);

            var bmiDeterminatorMock = new Mock<IBmiDeterminator>();

            bmiDeterminatorMock.Setup(m => m.DetermineBmi(It.IsAny<double>()))
                .Returns(classification);

            BmiCalculatorFacade bmiCalculatorFacade = new BmiCalculatorFacade(UnitSystem.Metric, bmiDeterminatorMock.Object);

            //act

            BmiResult result = bmiCalculatorFacade.GetResult(1, 1);


            //Console.WriteLine($"For classification: {classification} the result is: {result.Summary}");
            //Debug.WriteLine($"For classification: {classification} the result is: {result.Summary}");
            _outputHelper.WriteLine($"For classification: {classification} the result is: {result.Summary}");

            //assert
            //FluentAssertions

            result.Summary.Should().Be(summary);
        }
    }
}
