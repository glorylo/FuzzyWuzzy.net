using System;
using System.Collections.Generic;
using System.Text;
using FuzzyWuzzy.net;
using Xunit;

namespace FuzzyWuzzy.Tests
{

    public class FuzzTests
    {
        [Theory]
        [InlineData("energy", "synergy", 85)]
        public void GetStringDifferenceRatio(string text, string toCompareText, int expectedDistance)
        {
            var ratio = Fuzz.Ratio(text, toCompareText);
            Assert.True(ratio == expectedDistance);

        }
    }
}
