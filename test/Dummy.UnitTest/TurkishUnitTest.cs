using Dummy.TextLibrary;
using NUnit.Framework;

namespace Dummy.UnitTest
{
    public class TurkishUnitTest
    {
        public LanguageHelper Sut { get; set; }
        [SetUp]
        public void Setup()
        {
            Sut = new LanguageHelper(Language.Turkish);
        }

        [Test]
        public void PluralizeWordEndsWithBackVowels()
        {
            Assert.That(Sut.Pluralize("çiçek"), Is.EqualTo("çiçekler"));
            Assert.That(Sut.Pluralize("kedi"), Is.EqualTo("kediler"));
            Assert.That(Sut.Pluralize("göl"), Is.EqualTo("göller"));
        }

        [Test]
        public void PluralizeWordEndsWithFrontVowels()
        {
            Assert.That(Sut.Pluralize("at"), Is.EqualTo("atlar"));
            Assert.That(Sut.Pluralize("taký"), Is.EqualTo("takýlar"));
            Assert.That(Sut.Pluralize("kuzu"), Is.EqualTo("kuzular"));
        }
    }
}