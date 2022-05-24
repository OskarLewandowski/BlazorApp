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
            //How not doing
            ////arrange

            //BmiDeterminator bmiDeterminator = new BmiDeterminator();
            //double[] bmis = new double[] { 5, 10, 15, 18};

            ////act
            //foreach (var bmi in bmis)
            //{
            //    BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //    //assert

            //    Assert.Equal(BmiClassification.Underweight, result);
            //}

            //How doing
            //arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            //act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //assert

            Assert.Equal(BmiClassification.Underweight, result);
        }
    }
}
