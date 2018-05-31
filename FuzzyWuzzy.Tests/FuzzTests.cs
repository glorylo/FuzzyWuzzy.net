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
        public void GetStringRatio()
        {
            var ratio = Fuzz.Ratio("energy", "synergy");
            var result = Convert.ToInt32(Math.Round(ratio * 100));
            Assert.That(result == 85);
        }
    }
}
