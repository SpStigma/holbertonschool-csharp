using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            string str = "";
            int result = Str.UniqueChar(str);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_AllRepeatedChars_ReturnsMinusOne()
        {
            string str = "aaa";
            int result = Str.UniqueChar(str);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            string str = "abcdefg";
            int result = Str.UniqueChar(str);
            Assert.AreEqual(0, result);
        }
    }
}
