using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyOpeningBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[This is a string."));
        }

        [TestMethod]
        public void OnlyClosingBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("This is a string.]"));
        }

        [TestMethod]
        public void MultipleBracketSubsetsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[[]]]]]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void NormalStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Normal string returns true!"));
        }

        [TestMethod]
        public void MisorderedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void OrderedBracketsInStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[This], [is] a string [of] words.[]"));
        }

        [TestMethod]
        public void MisorderedBracketsInStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[This], [is] a string [of] words.]["));
        }

        [TestMethod]
        public void ExtraOpeningBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[This], [is] a string [of] words.["));
        }

        [TestMethod]
        public void ExtraClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[This], [is] a string [of] words.]"));
        }
    }
}
