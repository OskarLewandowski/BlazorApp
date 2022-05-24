namespace Library.Tests
{
    public class StringBuilderTests
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnsConcatenatedString()
        {
            // arrange

            StringBuilder sb = new StringBuilder();
            //StringBuilder sb2 = new StringBuilder();

            // act

            sb.Append("test")
              .Append("Test2");
            sb.Append(".cs");
            string result = sb.ToString();

            //sb2.Append("a").Append("b");
            //string result2 = sb2.ToString();

            // assert

            Assert.Equal("testTest2.cs", result);
            //Assert.Equal("ab", result2);
        }
    }
}