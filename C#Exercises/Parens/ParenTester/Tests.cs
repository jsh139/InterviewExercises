using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParenTester
{
    [TestClass]
    public class Tests
    {
        private ParenTester _sut;

        [TestInitialize]
        public void TestInit()
        {
            _sut = new ParenTester();
        }

        [TestMethod]
        public void NullShouldReturnTrue()
        {
            string toCheck = null;

            var result = _sut.AreBalanced(toCheck);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmptyStringShouldReturnTrue()
        {
            var toCheck = string.Empty;

            var result = _sut.AreBalanced(toCheck);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SingleParenShouldReturnFalse()
        {
            var toCheck = "(";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SingleClosingParenShouldReturnFalse()
        {
            var toCheck = ")";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OpenCloseParenShouldReturnTrue()
        {
            var toCheck = "()";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CloseOpenParenWithWrongNumberShouldReturnFalse()
        {
            var toCheck = "(()";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CloseOpenParenShouldReturnFalse()
        {
            var toCheck = ")(";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParenAndBracesShouldReturnTrue()
        {
            var toCheck = "{()}";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ParenAndBracesInWrongOrderShouldReturnFalse()
        {
            var toCheck = "({)}";

            var result = _sut.AreBalanced(toCheck);

            Assert.IsFalse(result);
        }
    }
}
