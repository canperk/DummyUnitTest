using Dummy.TextLibrary;
using Xunit;

namespace Dummy.UnitTest
{
    public class TurkishUnitTest
    {
        public LanguageHelper Sut { get; set; }
        public TurkishUnitTest()
        {
            Sut = new LanguageHelper(Language.Turkish);
        }

        [Fact]
        public void PluralizeWordEndsWithBackVowels()
        {
            Assert.Equal("çiçekler", Sut.Pluralize("çiçek"));
            Assert.Equal("kediler", Sut.Pluralize("kedi"));
            Assert.Equal("göller", Sut.Pluralize("göl"));
        }

        [Fact]
        public void PluralizeWordEndsWithFrontVowels()
        {
            Assert.Equal("atlar", Sut.Pluralize("at"));
            Assert.Equal("takılar", Sut.Pluralize("takı"));
            Assert.Equal("kuzular", Sut.Pluralize("kuzu"));
        }
    }
}