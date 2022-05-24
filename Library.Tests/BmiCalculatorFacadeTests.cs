using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Library.Tests
{
    public class BmiCalculatorFacadeTests
    {
        private const string OBESITY_SUMARRY = "You should take care of your obesity";
        private const string NORMAL_SUMARRY = "Your weight is normal, keep it up";
        private const string OVERWEIGHT_SUMARRY = "You are a bit overweight";

        [Theory]
        [InlineData(100, 170, 34.6, BmiClassification.Obesity, OBESITY_SUMARRY)]
        [InlineData(57, 170, 19.72, BmiClassification.Normal, NORMAL_SUMARRY)]
        [InlineData(70, 170, 24.22, BmiClassification.Normal, NORMAL_SUMARRY)]
        [InlineData(77, 160, 30.08, BmiClassification.Obesity, OBESITY_SUMARRY)]
        [InlineData(80, 190, 22.16, BmiClassification.Normal, NORMAL_SUMARRY)]
        [InlineData(90, 190, 24.93, BmiClassification.Overweight, OVERWEIGHT_SUMARRY)]
        public void GetResult_ForValidInputs_ReturnsCorrectRessult(double weight, double height, double bmi, BmiClassification classification, string summary)
        {
            //arrange
            IBmiDeterminator bmiDeterminator = new BmiDeterminator();
            bmiDeterminator.DetermineBmi(bmi);
            BmiCalculatorFacade bmiCalculatorFacade = new BmiCalculatorFacade(UnitSystem.Metric, bmiDeterminator);

            //act

            BmiResult result = bmiCalculatorFacade.GetResult(weight, height);

            //assert
            //FluentAssertions

            result.Bmi.Should().Be(bmi);
            result.BmiClassification.Should().Be(classification);
            result.Summary.Should().Be(summary);
        }
    }
}
