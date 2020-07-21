using System;

namespace Dummy.TextLibrary
{
    internal class LanguageHelperFactory
    {
        public static ILanguageHelper Create(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return new EnglishLanguageHelper();
                case Language.Turkish:
                    return new TurkishLanguageHelper();
                default: throw new InvalidOperationException("The parameter 'language' should be specified");
            }
        }
    }
}
