using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlcSimulator.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void CalcTest()
        {
            var target = new Model();
            double x = 1d, y = 2d;
            Assert.AreEqual(3d, target.Calc(x, y));
        }
    }
}