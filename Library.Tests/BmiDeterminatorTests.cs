namespace Library.Tests
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(5.0, BmiClassification.Underweight)]
        [InlineData(10.0, BmiClassification.Underweight)]
        [InlineData(18.0, BmiClassification.Underweight)]
        [InlineData(18.9, BmiClassification.Normal)]
        [InlineData(19.0, BmiClassification.Normal)]
        [InlineData(24.8, BmiClassification.Normal)]
        [InlineData(25.1, BmiClassification.Overweight)]
        [InlineData(27.8, BmiClassification.Overweight)]
        [InlineData(29.8, BmiClassification.Overweight)]
        [InlineData(34.8, BmiClassification.Obesity)]
        [InlineData(32.8, BmiClassification.Obesity)]
        [InlineData(34.9, BmiClassification.Obesity)]
        [InlineData(44.9, BmiClassification.ExtremObesity)]
        [InlineData(89.9, BmiClassification.ExtremObesity)]
        public void DetermineBmi_ForGivenBmi_ReturnsCorectClassification(double bmi, BmiClassification classification)
        {
            //arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            //act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //assert

            Assert.Equal(classification, result);
        }
    }
}
