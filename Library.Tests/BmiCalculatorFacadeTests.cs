using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    public class BmiCalculatorFacadeTests
    {
        [Theory]
        [InlineData(100, 170, 34.6, BmiClassification.Obesity)]
        [InlineData(57, 170, 19.72, BmiClassification.Normal)]
        [InlineData(70, 170, 24.22, BmiClassification.Normal)]
        [InlineData(77, 160, 30.08, BmiClassification.Obesity)]
        [InlineData(80, 190, 22.16, BmiClassification.Normal)]
        [InlineData(90, 190, 24.93, BmiClassification.Overweight)]
        public void GetResult_ForValidInputs_ReturnsCorrectRessult(double weight, double height, double bmi, BmiClassification classification)
        {
            //arrange
            IBmiDeterminator bmiDeterminator = new BmiDeterminator();
            bmiDeterminator.DetermineBmi(bmi);
            BmiCalculatorFacade bmiCalculatorFacade = new BmiCalculatorFacade(UnitSystem.Metric, bmiDeterminator);

            //act

            BmiResult result = bmiCalculatorFacade.GetResult(weight, height);

            //assert

            Assert.Equal(bmi, result.Bmi);
            Assert.Equal(classification, result.BmiClassification);
        }
    }
}
