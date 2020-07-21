using System.Security.Cryptography.X509Certificates;

namespace Dummy.TextLibrary
{
    public class LanguageHelper
    {
        private readonly ILanguageHelper languageHelper;
        public LanguageHelper(Language language)
        {
            languageHelper = LanguageHelperFactory.Create(language);
        }

        public string Pluralize(string text)
        {
            return languageHelper.Pluralize(text);
        }
    }
}
