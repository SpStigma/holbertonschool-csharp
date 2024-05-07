using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        private int[,] matrix = {
            { 0, 1, -2, 99, 100000 },
            { 13, -4, 566, -77777, 88 },
            { 10049, -666, 53, -1, 9999999 }
        };

        [Test]
        public void Divide_ByNonZeroIntegers_ReturnsCorrectQuotients()
        {
            int divisor = 2;
            int[,] expectedMatrix = {
                { 0, 0, -1, 49, 50000 },
                { 6, -2, 283, -38888, 44 },
                { 5024, -333, 26, 0, 4999999 }
            };

            var dividedMatrix = Matrix.Divide(matrix, divisor);

            Assert.That(dividedMatrix, Is.EqualTo(expectedMatrix));
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            var dividedMatrix = Matrix.Divide(matrix, 0);

            Assert.That(dividedMatrix, Is.Null);
        }

        [Test]
        public void Divide_ByZero_PrintsToConsole()
        {
            using (var consoleOutput = new ConsoleOutput())
            {
                Matrix.Divide(matrix, 0);

                Assert.That(consoleOutput.GetOutput(), Is.EqualTo("Num cannot be 0\n"));
            }
        }

        [Test]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            var dividedMatrix = Matrix.Divide(null, 9);

            Assert.That(dividedMatrix, Is.Null);
        }
    }
}
