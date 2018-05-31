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

//        public void GetEditDistanceTrivalCaseOneLeftString()
//        {
//            var distance = StringDiff.Distance("cars", string.Empty);
//            Assert.That(distance == 4);
//        }
//
//        [Test]
//        public void GetEditDistanceDeleteCase()
//        {
//            var distance = StringDiff.Distance("cars", "carts");
//            Assert.That(distance == 1);
//        }
//
//        [Test]
//        public void GetEditDistanceSubstitutionCase()
//        {
//            var distance = StringDiff.Distance("cars", "cats");
//            Assert.That(distance == 1);
//        }
//
//        [Test]
//        public void GetEditDistanceInsertCase()
//        {
//            var distance = StringDiff.Distance("car", "cars");
//            Assert.That(distance == 1);
//        }
//
//        [Test]
//        public void GetEditDistanceComplexCase()
//        {
//            var distance = StringDiff.Distance("cardudmum", "cardamom");
//            Assert.That(distance == 3);
//        }
    }
}
