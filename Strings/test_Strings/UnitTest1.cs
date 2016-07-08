using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace test_Strings
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_StringFun()
        {
            var s = new stringTempClass("my name is mariana");
            var r = s.StringFunc();
            Assert.AreEqual(4, r);
        }

        [TestMethod]
        public void Test_RevSen()
        {
            stringTempClass s = new stringTempClass("a b c d");
            string[] t = "a b c d".Split();
            string[] r = s.RevSen(t);
            Assert.AreEqual(t[0], r[r.Length-1]);
            Assert.AreEqual(t[1], r[r.Length - 2]);

        }

        [TestMethod]
        public void Test_SortSen()
        {
            stringTempClass s = new stringTempClass("z x w y");
            string[] t = "z x w y".Split();
            string[] r = s.SortSen(t);
            Assert.AreEqual(r[0], "w");
            Assert.AreEqual(r[1], "x");
            Assert.AreEqual(r[2], "y");
        }

    }
}
