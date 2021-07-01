using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        //Make sure a string of "[]" returns true.
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        //Make sure a string contain only one bracket returns false.
        [TestMethod]
        public void OnlyOneBracketIsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        //Make sure a string of two brackets along with other characters returns true.
        [TestMethod]
        public void BracketsPairWithCharactersReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[kd*] j"));
        }
        //Make sure a string of multiple bracket pairs along with other characters returns true.
        [TestMethod]
        public void MultipleBracketPairsWithCharactersReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[kd*] j[kjd ]d"));
        }
        //Make sure a string of two brackets facing the wrong way returns false.
        [TestMethod]
        public void BackwardsBracketPairReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        //Make sure a string with an odd number of brackets returns false.
        [TestMethod]
        public void OddBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]jlkjklj]"));
        }
        //Make sure exception is thrown if empty string is used as arguement.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NonStringArguementThrowsError()
        {
            BalancedBrackets.HasBalancedBrackets("");
        }
        //Make sure a string with an odd number of brackets returns false.
        [TestMethod]
        public void TestNestedBracketPairReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[dkj[dkjf]dk]"));
        }
        //Test that a string with no brackets returns false.
        [TestMethod]
        public void TestStringWithOutBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("dsfg"));
        }
    }
}
