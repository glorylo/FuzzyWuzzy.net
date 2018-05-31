using System;

namespace FuzzyWuzzy.net
{
    public static class StringDiff
    {
        public static int EditDistance(string text, string toCompareText)
        {

            var textLen = text.Length;
            var toCompareTextLen = toCompareText.Length;

            // step 1 -- trivial cases
            if (textLen == 0)
                return toCompareTextLen;

            if (toCompareTextLen == 0)
                return textLen;

            var distance = new int[textLen + 1, toCompareTextLen + 1];

            // step 2 
            for (var i = 0; i <= textLen; i++)
                distance[i, 0] = i;

            for (var j = 0; j <= toCompareTextLen; j++)
                distance[0, j] = j;

            // step 3 and step 4
            for (var i = 1; i <= textLen; i++)
            {
                for (var j = 1; j <= toCompareTextLen; j++)
                {
                    // step 5
                    var cost = text[i-1] == toCompareText[j-1] ? 0 : 1;

                    // step 6
                    distance[i, j] = Math.Min(
                            distance[i - 1, j - 1] + cost,
                            Math.Min(distance[i-1, j] + 1, distance[i, j - 1] + 1));
                }
            }

            return distance[textLen, toCompareTextLen];
        }
    }
}
