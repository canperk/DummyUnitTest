using Dummy.TextLibrary;
using NUnit.Framework;

namespace Dummy.UnitTest
{
    public class EnglishUnitTest
    {
        public LanguageHelper Sut { get; set; }
        [SetUp]
        public void Setup()
        {
            Sut = new LanguageHelper(Language.English);
        }

        [Test]
        public void PluralizeWordEndsWith_s()
        {
            Assert.That(Sut.Pluralize("cat"), Is.EqualTo("cats"));
            Assert.That(Sut.Pluralize("dog"), Is.EqualTo("dogs"));
            Assert.That(Sut.Pluralize("flower"), Is.EqualTo("flowers"));
        }

        [Test]
        public void PluralizeWordEndsWith_ies()
        {
            Assert.That(Sut.Pluralize("lady"), Is.EqualTo("ladies"));
            Assert.That(Sut.Pluralize("fairy"), Is.EqualTo("fairies"));
            Assert.That(Sut.Pluralize("study"), Is.EqualTo("studies"));
        }
    }
}