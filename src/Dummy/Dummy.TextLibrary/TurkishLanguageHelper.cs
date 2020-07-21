using System;
using System.Linq;

namespace Dummy.TextLibrary
{
    internal class TurkishLanguageHelper : ILanguageHelper
    {
        public string Pluralize(string text)
        {
            var suffix = "ler";
            var backVowels = new char[] { 'a', 'ı', 'o', 'u' };

            var enumerator = text.Reverse().GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                if (backVowels.Contains(enumerator.Current))
                {
                    suffix = "lar";
                    break;
                }
            }
            return text + suffix;
        }
    }
}
