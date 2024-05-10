using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindromeOneWord()
        {
            string str = "blue";

            Assert.That(Text.Str.IsPalindrome(str), Is.False);
        }

        [Test]
        public void IsPalindromeASentence()
        {
            string str = "A blue World";

            Assert.That(Text.Str.IsPalindrome(str), Is.False);
        }

        [Test]
        public void IsPalindromeIsEmpty()
        {
            string str = "";

            Assert.That(Text.Str.IsPalindrome(str), Is.True);
        }
    }
}