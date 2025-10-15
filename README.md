Credit Score Classifier

A compact, production-style C#/.NET library that classifies credit scores on two industry scales — FICO and VantageScore — with an exhaustive MSTest suite targeting boundary conditions and invalid input handling.

Tech: .NET 8 • C# • MSTest

Features

Deterministic classification for FICO and VantageScore ranges

Clear, branch-only business rules (no I/O, no side effects)

Input validation with precise exceptions

Comprehensive boundary coverage (BVA) in unit tests

Installation & Build
dotnet restore
dotnet build -c Release
dotnet test  -c Release

Usage
using CreditScoreClassifier;

var label1 = ScoreQualifier.QualifyScore(ScoreQualifier.ScoreType.FICO,    740); // "Very Good"
var label2 = ScoreQualifier.QualifyScore(ScoreQualifier.ScoreType.Vantage, 781); // "Excellent"


API

public static class ScoreQualifier
{
    public enum ScoreType { FICO, Vantage }

    /// Returns a rating label for the given score on the specified scale.
    /// Throws ArgumentOutOfRangeException for values outside the supported range.
    public static string QualifyScore(ScoreType type, int actualScore);
}

Classification Rules
FICO (300–850)
Range	Label
300–579	Poor
580–669	Fair
670–739	Good
740–799	Very Good
800–850	Exceptional
VantageScore (300–850)
Range	Label
300–499	Very Poor
500–600	Poor
601–660	Fair
661–780	Good
781–850	Excellent

Values < 300 or > 850 result in ArgumentOutOfRangeException.

Testing

Framework: MSTest

Focus: Boundary Value Analysis (min, min+1, band edges, max-1, max) + invalid partitions

Run locally:

dotnet test -c Release

Project Layout
src/
  CreditScoreClassifier/
    ScoreQualifier.cs
    CreditScoreClassifier.csproj
tests/
  CreditScoreClassifier.Tests/
    ScoreQualifierTests.cs
    CreditScoreClassifier.Tests.csproj
week2-credit-score-classifier.sln

Quality Notes

Single-purpose API, explicit control flow, no hidden state

Tests as executable specification; one assertion per test where practical

Guard clauses for invalid input, domain-accurate labels

License

MIT
