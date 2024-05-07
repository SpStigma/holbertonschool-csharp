namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Add_ReturnsSumOfTwoIntegers()
        {
            int a = 10;
            int b = 10;

            int result = Operations.Add(a, b);

            Assert.That(result, Is.EqualTo(20));
        }
    }
}