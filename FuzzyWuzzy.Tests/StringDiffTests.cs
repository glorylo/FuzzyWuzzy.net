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
            var distance = StringDiff.Distance(string.Empty, string.Empty);
            Assert.That(distance == 0);
        }

        [Test]
        public void GetEditDistanceTrivalCaseOneRightString()
        {
            var distance = StringDiff.Distance(string.Empty, "cars");
            Assert.That(distance == 4);
        }

        [Test]
        public void GetEditDistanceTrivalCaseOneLeftString()
        {
            var distance = StringDiff.Distance("cars", string.Empty);
            Assert.That(distance == 4);
        }

        [Test]
        public void GetEditDistanceDeleteCase()
        {
            var distance = StringDiff.Distance("cars", "carts");
            Assert.That(distance == 1);
        }

        [Test]
        public void GetEditDistanceSubstitutionCase()
        {
            var distance = StringDiff.Distance("cars", "cats");
            Assert.That(distance == 1);
        }

        [Test]
        public void GetEditDistanceInsertCase()
        {
            var distance = StringDiff.Distance("car", "cars");
            Assert.That(distance == 1);
        }

        [Test]
        public void GetEditDistanceComplexCase()
        {
            var distance = StringDiff.Distance("cardudmum", "cardamom");
            Assert.That(distance == 3);
        }
    }
}
