using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4 );
        }

        [TestMethod]
        public void TestEven()
        {
            bool result5 = Program.IsEven(2);
            Assert.AreEqual(true, result5);

            bool result6 = Program.IsEven(6);
            Assert.AreEqual(true, result6);
        }

        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);

            int result2 = Program.Ceil((float)-2.3f);
            Assert.AreEqual(-2, result2);
        }

        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.FLoor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.FLoor(-2.3f);
            Assert.AreEqual(-3, result2);
        }
       
    }
}
