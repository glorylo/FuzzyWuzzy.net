using System;
using System.Collections.Generic;
using System.Text;
using FuzzyWuzzy.net;
using NUnit.Framework;

namespace FuzzyWuzzy.Tests
{
    [TestFixture]
    public class FuzzTests
    {
        [Test]
        public void GetStringDifferenceRatio()
        {
            var ratio = Fuzz.Ratio("energy", "synergy");
            Assert.That(ratio == 85);
        }
    }
}
