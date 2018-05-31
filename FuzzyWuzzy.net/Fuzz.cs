using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzyWuzzy.net
{
    public static class Fuzz
    {
        public static int Ratio(string text, string toCompareText)
        {
            var textLen = text.Length;
            var toCompareLen = toCompareText.Length;

            var totalChars = textLen + toCompareLen;
            var distance = StringDiff.Distance(text, toCompareText);

            var ratio = (totalChars - distance) * 1.0 / totalChars;            
            return Convert.ToInt32(Math.Round(ratio * 100)); ;
        }


        public static int PartialRatio(string text, string toCompareText)
        {
            throw new NotImplementedException();
        }

        public static int TokenSortRatio(string text, string toCompareText)
        {
            throw new NotImplementedException();
        }

        public static int TokenSetRatio(string text, string toCompareText)
        {
            throw new NotImplementedException();
        }


    }
}
