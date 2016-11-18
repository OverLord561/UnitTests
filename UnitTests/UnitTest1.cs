using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForSplitBySpace()
        {           
            //arrenge
            string str = "Have a nice day";
            int countExpected = 4;

            //act

            string[] subStrings = str.Split(' ');
            int countActual= subStrings.Length;

            //assert

            Assert.AreEqual(countExpected, countActual);

        }


        [TestMethod]
        public void TestForSubStringMethod()
        {

            //arrenge
            string str = "Have a nice day";
            int startIndex = str.IndexOf('n');
            int length = str.Length - startIndex;
            string subExpected = "nice day";

            //act

            string subActual = str.Substring(startIndex, length);

            //assert

            Assert.AreEqual(subExpected, subActual);

        }
    }
}
