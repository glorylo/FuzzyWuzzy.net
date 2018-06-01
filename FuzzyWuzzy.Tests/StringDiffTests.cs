using FuzzyWuzzy.net;
using Xunit;

namespace FuzzyWuzzy.Tests
{
    public class StringDiffTests
    {
        [Theory]
        [InlineData("", "", 0)]
        public void GetEditDistanceTrivalCase(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(text, compareText);
            Assert.Equal(expectedDistance, distance);
        }

        [Theory]
        [InlineData("", "cars", 4)]
        public void GetEditDistanceTrivalCaseOneRightString(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(string.Empty, "cars");
            Assert.Equal(expectedDistance, distance);
        }

        [Theory]
        [InlineData("cars", "", 4)]

        public void GetEditDistanceTrivalCaseOneLeftString(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(text, compareText);
            Assert.True(distance == expectedDistance);
        }

        [Theory]
        [InlineData("cars", "carts", 1)]

        public void GetEditDistanceDeleteCase(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(text, compareText);
            Assert.True(distance == expectedDistance);
        }

        [Theory]
        [InlineData("cars", "cats", 1)]
        public void GetEditDistanceSubstitutionCase(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(text, compareText);
            Assert.True(distance == expectedDistance);
        }

        [Theory]
        [InlineData("car", "cars", 1)]
        public void GetEditDistanceInsertCase(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(text, compareText);
            Assert.True(distance == expectedDistance);
        }
        [Theory]
        [InlineData("cardudmum", "cardamom", 3)]
        [InlineData("synergy", "energy", 2)]
        public void GetEditDistanceComplexCase(string text, string compareText, int expectedDistance)
        {
            var distance = StringDiff.Distance(text, compareText);
            Assert.True(distance == expectedDistance);
        }
    }
}
