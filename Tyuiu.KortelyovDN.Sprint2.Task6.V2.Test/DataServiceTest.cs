using Tyuiu.KortelyovDN.Sprint2.Task6.V2.Lib;

namespace Tyuiu.KortelyovDN.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeasonWinter()
        {
            DataService ds = new DataService();
            int value = 1; 
            string res = ds.FindMonthSeason(value);
            string wait = "Зима";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeasonSummer()
        {
            DataService ds = new DataService();
            int value = 8;  
            string res = ds.FindMonthSeason(value);
            string wait = "Лето";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthSeasonException()
        {
            DataService ds = new DataService();
            int value = 15;  
            Assert.ThrowsException<ArgumentException>(() => ds.FindMonthSeason(value));
        }
    }
}





