using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestProgramOutput()
        {
            Assert.AreEqual("Run on Jenkins", Program.CreateMessage());
        }
    }
}
