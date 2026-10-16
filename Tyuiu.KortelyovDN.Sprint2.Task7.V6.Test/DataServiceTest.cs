using Tyuiu.KortelyovDN.Sprint2.Task7.V6.Lib;

namespace Tyuiu.KortelyovDN.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea_Inside()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_Outside_Bottom()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_Outside_Hole()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}