using Tyuiu.KortelyovDN.Sprint2.Task3.V14.Lib;

namespace Tyuiu.KortelyovDN.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2; 
            double res = ds.Calculate(x);
            double wait = -25; 
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0; 
            double res = ds.Calculate(x);
            double wait = 0.75; 
            Assert.AreEqual(wait, res);
        }
    }
}