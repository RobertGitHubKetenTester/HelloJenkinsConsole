using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloJenkinsConsole;

namespace HelloJenkinsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMessage() { 
        
            Assert.AreEqual("Hello daar Jenkins",Program.CreateMessage());
        }
    }
}
