using System;

namespace CreditScoreClassifier
{
    public static class ScoreQualifier
    {
        public enum ScoreType { FICO, Vantage }

        /// <summary>
        /// Classifies a credit score for a given scoring model.
        /// Allowed range: 300..850 inclusive; otherwise throws ArgumentOutOfRangeException.
        /// </summary>
        public static string QualifyScore(ScoreType type, int actualScore)
        {
            if (actualScore < 300 || actualScore > 850)
                throw new ArgumentOutOfRangeException(nameof(actualScore), "Score must be in [300..850].");

            return type switch
            {
                ScoreType.FICO => actualScore <= 579 ? "Poor"
                                   : actualScore <= 669 ? "Fair"
                                   : actualScore <= 739 ? "Good"
                                   : actualScore <= 799 ? "Very Good"
                                   : "Exceptional",

                ScoreType.Vantage => actualScore <= 499 ? "Very Poor"
                                      : actualScore <= 600 ? "Poor"
                                      : actualScore <= 660 ? "Fair"
                                      : actualScore <= 780 ? "Good"
                                      : "Excellent",

                _ => throw new ArgumentOutOfRangeException(nameof(type), "Unknown score type.")
            };
        }
    }
}
