using Tyuiu.KortelyovDN.Sprint2.Task4.V30.Lib;

namespace Tyuiu.KortelyovDN.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditionTrue()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 49.000;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditionFalse()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 5.000;

            Assert.AreEqual(wait, res);
        }
    }
}





