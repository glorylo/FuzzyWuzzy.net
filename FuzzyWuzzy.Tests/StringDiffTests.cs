using FuzzyWuzzy.net;
using NUnit.Framework;

namespace FuzzyWuzzy.Tests
{
    [TestFixture]
    public class StringDiffTests
    {
        [Test]
        public void GetEditDistanceTrivalCase()
        {
            var distance = StringDiff.EditDistance(string.Empty, string.Empty);
            Assert.That(distance == 0);
        }

        [Test]
        public void GetEditDistanceTrivalCaseOneRightString()
        {
            var distance = StringDiff.EditDistance(string.Empty, "cars");
            Assert.That(distance == 4);
        }

        [Test]
        public void GetEditDistanceTrivalCaseOneLeftString()
        {
            var distance = StringDiff.EditDistance("cars", string.Empty);
            Assert.That(distance == 4);
        }

        [Test]
        public void GetEditDistanceDeleteCase()
        {
            var distance = StringDiff.EditDistance("cars", "carts");
            Assert.That(distance == 1);
        }

        [Test]
        public void GetEditDistanceSubstitutionCase()
        {
            var distance = StringDiff.EditDistance("cars", "cats");
            Assert.That(distance == 1);
        }

        [Test]
        public void GetEditDistanceInsertCase()
        {
            var distance = StringDiff.EditDistance("car", "cars");
            Assert.That(distance == 1);
        }

        [Test]
        public void GetEditDistanceComplexCase()
        {
            var distance = StringDiff.EditDistance("cardudmum", "cardamom");
            Assert.That(distance == 3);
        }
    }
}
