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

        [Fact]
        public void PluralizeWordEndsWith_s()
        {
            Assert.Equal("cats", Sut.Pluralize("cat"));
            Assert.Equal("dogs", Sut.Pluralize("dog"));
            Assert.Equal("flowers", Sut.Pluralize("flower"));
        }

        [Fact]
        public void PluralizeWordEndsWith_ies()
        {
            Assert.Equal("ladies", Sut.Pluralize("lady"));
            Assert.Equal("fairies", Sut.Pluralize("fairy"));
            Assert.Equal("studies", Sut.Pluralize("study"));
        }
    }
}