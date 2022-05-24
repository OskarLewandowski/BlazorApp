namespace Library.Tests
{
    public class BmiDeterminatorTests
    {
        [Fact]
        public void DetermineBmi_ForBmiBelow18_5_ReturnsUnderweightClassification()
        {
            //arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();
            double bmi = 10;

            //act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //assert

            Assert.Equal(BmiClassification.Underweight, result);
        }
    }
}
