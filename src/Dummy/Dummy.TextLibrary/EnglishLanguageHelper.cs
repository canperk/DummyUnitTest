using System;

namespace Dummy.TextLibrary
{
    internal class EnglishLanguageHelper : ILanguageHelper
    {
        public string Pluralize(string text)
        {
            if (text.EndsWith("y"))
            {
                return text.Substring(0, text.Length - 1) + "ies";
            }
            return text + "s";
        }
    }
}
