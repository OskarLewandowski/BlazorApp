namespace Library.Tests
{
    public class StringBuilderTests
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnsConcatenatedString()
        {
            // arrange

            StringBuilder sb = new StringBuilder();

            // act

            sb.Append("test")
              .Append("Test2");

            sb.Append(".cs");

            string result = sb.ToString();

            // assert

            Assert.Equal("testTest2.cs", result);
        }
    }
}