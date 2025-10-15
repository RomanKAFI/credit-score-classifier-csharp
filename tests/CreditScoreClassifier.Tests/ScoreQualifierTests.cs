using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static CreditScoreClassifier.ScoreQualifier;

namespace CreditScoreClassifier.Tests
{
    [TestClass]
    public class ScoreQualifierTests
    {
        // FICO
        [TestMethod] public void FICO_299_Throws() =>
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => QualifyScore(ScoreType.FICO, 299));

        [TestMethod] public void FICO_300_Poor() => Assert.AreEqual("Poor", QualifyScore(ScoreType.FICO, 300));
        [TestMethod] public void FICO_579_Poor() => Assert.AreEqual("Poor", QualifyScore(ScoreType.FICO, 579));
        [TestMethod] public void FICO_580_Fair() => Assert.AreEqual("Fair", QualifyScore(ScoreType.FICO, 580));
        [TestMethod] public void FICO_669_Fair() => Assert.AreEqual("Fair", QualifyScore(ScoreType.FICO, 669));
        [TestMethod] public void FICO_670_Good() => Assert.AreEqual("Good", QualifyScore(ScoreType.FICO, 670));
        [TestMethod] public void FICO_739_Good() => Assert.AreEqual("Good", QualifyScore(ScoreType.FICO, 739));
        [TestMethod] public void FICO_740_VeryGood() => Assert.AreEqual("Very Good", QualifyScore(ScoreType.FICO, 740));
        [TestMethod] public void FICO_799_VeryGood() => Assert.AreEqual("Very Good", QualifyScore(ScoreType.FICO, 799));
        [TestMethod] public void FICO_800_Exceptional() => Assert.AreEqual("Exceptional", QualifyScore(ScoreType.FICO, 800));
        [TestMethod] public void FICO_850_Exceptional() => Assert.AreEqual("Exceptional", QualifyScore(ScoreType.FICO, 850));
        [TestMethod] public void FICO_851_Throws() =>
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => QualifyScore(ScoreType.FICO, 851));

        // Vantage
        [TestMethod] public void Vantage_299_Throws() =>
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => QualifyScore(ScoreType.Vantage, 299));

        [TestMethod] public void Vantage_300_VeryPoor() => Assert.AreEqual("Very Poor", QualifyScore(ScoreType.Vantage, 300));
        [TestMethod] public void Vantage_499_VeryPoor() => Assert.AreEqual("Very Poor", QualifyScore(ScoreType.Vantage, 499));
        [TestMethod] public void Vantage_500_Poor() => Assert.AreEqual("Poor", QualifyScore(ScoreType.Vantage, 500));
        [TestMethod] public void Vantage_600_Poor() => Assert.AreEqual("Poor", QualifyScore(ScoreType.Vantage, 600));
        [TestMethod] public void Vantage_601_Fair() => Assert.AreEqual("Fair", QualifyScore(ScoreType.Vantage, 601));
        [TestMethod] public void Vantage_660_Fair() => Assert.AreEqual("Fair", QualifyScore(ScoreType.Vantage, 660));
        [TestMethod] public void Vantage_661_Good() => Assert.AreEqual("Good", QualifyScore(ScoreType.Vantage, 661));
        [TestMethod] public void Vantage_780_Good() => Assert.AreEqual("Good", QualifyScore(ScoreType.Vantage, 780));
        [TestMethod] public void Vantage_781_Excellent() => Assert.AreEqual("Excellent", QualifyScore(ScoreType.Vantage, 781));
        [TestMethod] public void Vantage_850_Excellent() => Assert.AreEqual("Excellent", QualifyScore(ScoreType.Vantage, 850));
        [TestMethod] public void Vantage_851_Throws() =>
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => QualifyScore(ScoreType.Vantage, 851));
    }
}
