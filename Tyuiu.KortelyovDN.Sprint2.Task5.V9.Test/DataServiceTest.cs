using Tyuiu.KortelyovDN.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KortelyovDN.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay_MiddleOfMonth()
        {
            DataService ds = new DataService();
            int m = 10; 
            int n = 15; 
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "16.10";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_EndOfMonth()
        {
            DataService ds = new DataService();
            int m = 2; 
            int n = 28;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "01.03"; 

            Assert.AreEqual(wait, res);
        }
    }
}





