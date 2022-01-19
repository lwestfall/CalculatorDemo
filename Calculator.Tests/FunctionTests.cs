namespace Calculator.Tests;
using NUnit.Framework;
using static Calculator.Functions;

[TestFixture]
public class FunctionTests
{
    // good tests are split into the Three A's: Arrange, Act, and Assert
    [Test]
    [TestCase(5, 4, 9)]    // Big positive number first, Small positive number second
    [TestCase(4, 6, 10)]  //Small positive number, Big positive Number
    [TestCase(-10, 6, -4)] //Big Negative Number, Small number
    [TestCase(-12, 24, 12)] //Small Negative Number, Big Positive Number
    [TestCase(-13, -7, -20)] //Big Negative Number, Small Negative Number
    public void AddReturnsCorrectAnswer(int a, int b, int expectedSum)
    {
        // Arrange done by mapping TestCase Variables to Method Parameters
        /*
        int a = 1;
        int b = 2;
        int expectedSum = 3;
        */

        // act
        var actualSum = Add(a, b);

        // assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    /*Fuction Name: SubtractReturnsCorrectAnswer
    **Parameters: N/A
    **Return: void
    */
    [Test]
    [TestCase(5, 4, 1)]      // Big positive number first, Small positive number second
    [TestCase(4, 6, -2)]     //Small positive number, Big positive Number
    [TestCase(-10, 6, -16)]  //Big Negative Number, Small number
    [TestCase(-12, 24, -36)] //Small Negative Number, Big Positive Number
    [TestCase(-13, -7, -6)]  //Big Negative Number, Small Negative Number
    [TestCase(-4, -12, 8)]   //Small Negative Number, Big Negative Number
    public void SubtractReturnsCorrectAnswer(int a, int b, int expectedDiff)
    {
        // Arrange done by mapping TestCase Variables to Method Parameters
        /*
        int a = TestCaseAttribute(a);
        int b;
        int expectedDiff = -1;
        */

        // act
        var actualDiff = Subtract(a, b);

        // assert
        Assert.AreEqual(expectedDiff, actualDiff);
    }

    /*Fuction Name: MultiplyReturnsCorrectAnswer
    **Parameters: N/A
    **Return: void
    */
    [Test]
    [TestCase(5, 4, 20)]    //Positive, Positive
    [TestCase(3, -4, -12)]  //Negative, Negative
    [TestCase(-10, -5, 50)] //Negative, Negative

    public void MultiplyReturnsCorrectAnswer(int a, int b, int expectedProduct)
    {
        // Arrange done by mapping TestCase Variables to Method Parameters
        /*
        int a;
        int b;
        int expectedProduct = 2;
        */

        // act
        var actualProduct = Multiply(a, b);

        // assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }

    /*Fuction Name: DivideReturnsCorrectAnswer
    **Parameters: N/A
    **Return: void
    */
    [Test]
    [TestCase(10, 2, 5)]    // Big positive Numerator, Small positive Denominator
    [TestCase(3, 4, 0.75)]  //Small Positive Numerator, Big Positive Denominator
    [TestCase(-14, 7, -2)] //Big Negative Numerator, Small Positive Denominator
    [TestCase(-12, 36, -0.33333333333333331d)] //Small Negative Numerator, Big Positive Number
    [TestCase(18, -6, -3)] //Big Positive Numerator, Small Negative Denominator
    [TestCase(50, -200, -0.25)]  //Small Positve Numerator, Big Negative Denominator

    public void DivideReturnsCorrectAnswer(int a, int b, double expectedQuotient)
    {
        // Arrange done by mapping TestCase Variables to Method Parameters
        /*
        int a = 1;
        int b = 2;
        double expectedQuotient = 0.5d;
        */

        // act
        var actualQuotient = Divide(a, b);

        // assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
}