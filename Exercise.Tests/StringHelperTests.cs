namespace Exercise.Tests
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("Alice have cat", "cat have Alice")]
        [InlineData("test is test", "test is test")]
        [InlineData("big car and small truck", "truck small and car big")]
        [InlineData("This is Example opinion", "opinion Example is This")]
        [InlineData("12345-67890", "12345-67890")]
        [InlineData("12345  67890", "67890  12345")]
        public void ReverseWords_ForGivenSentence_ReturnsReversedSentence(string sentence, string correctSentence)
        {
            //arrange

            //act

            string result = StringHelper.ReverseWords(sentence);

            //assert
            //Assert.Equal(correctSentence, result);

            result.Should().Be(correctSentence);
        }

        [Theory]
        [InlineData("ala")]
        [InlineData("KamilœlimaK")]
        [InlineData("aLa")]
        [InlineData("KAJAK")]
        [InlineData("pop")]
        public void IsPalindrome_ForAPalindromWord_RetrunsTrueValue(string word)
        {
            //arrange

            //act

            var result = StringHelper.IsPalindrome(word);

            //assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("ola")]
        [InlineData("Ala")]
        [InlineData("Kuba")]
        [InlineData("Oskar")]
        [InlineData("test")]
        public void IsPalindrome_ForANonPalindromWord_RetrunsFalseValue(string word)
        {
            //arrange

            //act
            var result = StringHelper.IsPalindrome(word);

            //assert
            result.Should().BeFalse();
        }
    }
}