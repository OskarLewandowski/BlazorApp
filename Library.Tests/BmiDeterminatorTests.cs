namespace Library.Tests
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(10.0)]
        [InlineData(17.0)]
        [InlineData(18.0)]
        [InlineData(8.0)]
        [InlineData(1.0)]
        public void DetermineBmi_ForBmiBelow18_5_ReturnsUnderweightClassification(double bmi)
        {
            //arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            //act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //assert

            Assert.Equal(BmiClassification.Underweight, result);
        }
    }
}
