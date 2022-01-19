using NUnit.Framework;
using static Calculator.Functions;

namespace Calculator.Tests;

[TestFixture]
public class FunctionTests
{
    // good tests are split into the Three A's: Arrange, Act, and Assert
        [TestCase(5,4, ExpectedResult=9)]    // Big positive number first, Small positive number second
        [TestCase(4,6, ExpectedResult=10)]  //Small positive number, Big positive Number
        [TestCase(-10,6, ExpectedResult=-4)] //Big Negative Number, Small number
        [TestCase(-12,24, ExpectedResult=12)] //Small Negative Number, Big Positive Number
        [TestCase(-13,-7, ExpectedResult=-20)] //Big Negative Number, Small Negative Number
    public int AddReturnsCorrectAnswer(int a, int b)
    {
        /*
        // arrange
        int a = 1;
        int b = 2;
        int expectedSum = 3;

        // act
        int actualSum = Add(a, b);

        // assert
        Assert.AreEqual(expectedSum, actualSum);
        */
        return a + b;
    }

    /*Fuction Name: SubtractReturnsCorrectAnswer
    **Parameters: N/A
    **Return: void
    */
        [TestCase(5,4, ExpectedResult=1)]    // Big positive number first, Small positive number second
        [TestCase(4,6, ExpectedResult=-2)]  //Small positive number, Big positive Number
        [TestCase(-10,6, ExpectedResult=-16)] //Big Negative Number, Small number
        [TestCase(-12,24, ExpectedResult=-36)] //Small Negative Number, Big Positive Number
        [TestCase(-13,-7, ExpectedResult=-6)] //Big Negative Number, Small Negative Number
        [TestCase(-4,-12, ExpectedResult=8)]  //Small Negative Number, Big Negative Number
    public int SubtractReturnsCorrectAnswer(int a, int b)
    {
        /*
        // arrange
        int a = 1;
        int b = 2;
        int expectedDiff = -1;

        // act
        int actualDiff = Subtract(a, b);

        // assert
        Assert.AreEqual(expectedDiff, actualDiff);
        */
        return a - b;
    }

    /*Fuction Name: MultiplyReturnsCorrectAnswer
    **Parameters: N/A
    **Return: void
    */
        [TestCase(5,4, ExpectedResult=20)]    //Positive, Positive
        [TestCase(3,-4, ExpectedResult=-12)]  //Negative, Negative
        [TestCase(-10,-5, ExpectedResult=50)] //Negative, Negative

    public int MultiplyReturnsCorrectAnswer(int a, int b)
    {
        /*
        // arrange
        int a = 1;
        int b = 2;
        int expectedProduct = 2;

        // act
        int actualProduct = Multiply(a, b);

        // assert
        Assert.AreEqual(expectedProduct, actualProduct);
        */
        return a * b;
    }

    /*Fuction Name: DivideReturnsCorrectAnswer
    **Parameters: N/A
    **Return: void
    */
        [TestCase(10,2, ExpectedResult=5)]    // Big positive Numerator, Small positive Denominator
        [TestCase(3,4, ExpectedResult=0.75)]  //Small Positive Numerator, Big Positive Denominator
        [TestCase(-14,7, ExpectedResult=-2)] //Big Negative Numerator, Small Positive Denominator
        [TestCase(-12,36, ExpectedResult=-0.33333333333333331d)] //Small Negative Numerator, Big Positive Number
        [TestCase(18,-6, ExpectedResult=-3)] //Big Positive Numerator, Small Negative Denominator
        [TestCase(50,-200, ExpectedResult=-0.25)]  //Small Positve Numerator, Big Negative Denominator

    public double DivideReturnsCorrectAnswer(double a, double b)
    {
        /*
        // arrange
        int a = 1;
        int b = 2;
        double expectedQuotient = 0.5d;

        // act
        double actualQuotient = Divide(a, b);

        // assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
        */
        return a / b;
    }
}