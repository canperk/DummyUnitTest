using Dummy.TextLibrary;
using Xunit;

namespace Dummy.UnitTest
{
    public class EnglishUnitTest
    {
        public LanguageHelper Sut { get; set; }
        public EnglishUnitTest()
        {
            Sut = new LanguageHelper(Language.English);
        }

        [Theory]
        [InlineData("cats", "cat")]
        [InlineData("dogs", "dog")]
        [InlineData("flowers", "flower")]
        [InlineData("ladies", "lady")]
        [InlineData("fairies", "fairy")]
        [InlineData("studies", "study")]
        public void GivenWords_ArePluralized(string expected, string value)
        {
            Assert.Equal(expected, Sut.Pluralize(value));
        }
    }
}