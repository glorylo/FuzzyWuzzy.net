using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzyWuzzy.net
{
    public static class Fuzz
    {
        public static double Ratio(string text, string toCompareText)
        {
            var textLen = text.Length;
            var toCompareLen = toCompareText.Length;

            var totalChars = textLen + toCompareLen;
            var distance = StringDiff.EditDistance(text, toCompareText);

            return (totalChars - distance) * 1.0 / totalChars;
        }
    }
}
