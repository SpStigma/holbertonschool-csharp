using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        List<int> numbers;

        [SetUp]
        public void Setup()
        {
            numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        [Test]
        public void MaxNormal()
        {
            int greaterNumber = MyMath.Operations.Max(numbers);

            Assert.That(greaterNumber, Is.EqualTo(3));
        }

        [Test]
        public void MaxEmpty()
        {
            numbers.Clear();

            Assert.That(MyMath.Operations.Max(numbers), Is.EqualTo(0));
        }
    }
}