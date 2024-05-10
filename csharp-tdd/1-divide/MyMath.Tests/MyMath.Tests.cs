using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        int[,] testmatrix;
        
        [SetUp]
        public void Setup()
        {
            testmatrix = new int[2, 2];
            testmatrix[0, 0] = 2;
            testmatrix[0, 1] = 4;
            testmatrix[1, 0] = 6;
            testmatrix[1, 1] = 8;
        }
        [Test]
        public void MatrixDividedByIntegers()
        {
            int divisor = 2;

            int[,] resultMatrix = MyMath.Matrix.Divide(testmatrix, divisor);
            Assert.AreEqual(1, resultMatrix[0, 0]);
            Assert.Pass();
        }

        [Test]
        public void MatrixDividedByZero()
        {
            Assert.IsNull(MyMath.Matrix.Divide(testmatrix, 0));
            Assert.Pass();
        }

        public void MatrixIsNone()
        {
            // Arrange
            int[,] matrix = null;
            int divisor = 2;

            // Act
            int[,] result = MyMath.Matrix.Divide(matrix, divisor);

            // Assert
            Assert.IsNull(result);
        }
    }
}