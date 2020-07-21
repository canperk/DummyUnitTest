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
            Assert.That(Sut.Pluralize("�i�ek"), Is.EqualTo("�i�ekler"));
            Assert.That(Sut.Pluralize("kedi"), Is.EqualTo("kediler"));
            Assert.That(Sut.Pluralize("g�l"), Is.EqualTo("g�ller"));
        }

        [Test]
        public void PluralizeWordEndsWithFrontVowels()
        {
            Assert.That(Sut.Pluralize("at"), Is.EqualTo("atlar"));
            Assert.That(Sut.Pluralize("tak�"), Is.EqualTo("tak�lar"));
            Assert.That(Sut.Pluralize("kuzu"), Is.EqualTo("kuzular"));
        }
    }
}