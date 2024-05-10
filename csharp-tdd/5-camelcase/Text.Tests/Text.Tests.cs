using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCaseNormal()
        {
            string sentence = "bonjour La Mif";

            Assert.That(Text.Str.CamelCase(sentence), Is.EqualTo(3));
        }

        [Test]
        public void CamelCaseEmpty()
        {
            string sentence = "";

            Assert.That(Text.Str.CamelCase(sentence), Is.EqualTo(1));
        }

        [Test]
        public void CamelCaseNull()
        {
            string sentence = null;

            Assert.That(Text.Str.CamelCase(sentence), Is.EqualTo(0));
        }
    }
}