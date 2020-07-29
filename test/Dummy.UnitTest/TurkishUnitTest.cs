using Dummy.TextLibrary;
using System.ComponentModel;
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

        [Theory]
        [InlineData("çiçekler", "çiçek")]
        [InlineData("kediler", "kedi")]
        [InlineData("göller", "göl")]
        [InlineData("atlar", "at")]
        [InlineData("takılar", "takı")]
        [InlineData("kuzular", "kuzu")]
        public void GivenWords_ArePluralized(string expected, string value)
        { 
            Assert.Equal(expected, Sut.Pluralize(value));
        }
    }
}