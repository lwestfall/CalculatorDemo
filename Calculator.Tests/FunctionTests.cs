using NUnit.Framework;
using static Calculator.Functions;

namespace Calculator.Tests;

[TestFixture]
public class FunctionTests
{
    // good tests are split into the Three A's: Arrange, Act, and Assert
    [Test]
    public void AddReturnsCorrectAnswer()
    {
        // arrange
        int a = 1;
        int b = 2;
        int expectedSum = 3;

        // act
        int actualSum = Add(a, b);

        // assert
        Assert.AreEqual(expectedSum, actualSum);
    }
}