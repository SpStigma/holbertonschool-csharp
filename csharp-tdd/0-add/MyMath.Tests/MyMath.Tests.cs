using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void AddTwoNumberPositive()
        {
            int a = 10;
            int b = 10;

            int result = MyMath.Operations.Add(a, b);

            Assert.That(result, Is.EqualTo(20));
        }
    }
}