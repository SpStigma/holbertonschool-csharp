using Nunit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_ReturnsSumOfTwoIntegers()
        {
            int a = 10;
            int b = 10;

            int result = Operations.Add(a, b);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Add_WhenMinAndMaxAdded_ReturnsNegOne()
        {
            var testSum = Operations.Add(int.MinValue, int.MaxValue);

            Assert.That(testSum == -1);
        }
    }
}