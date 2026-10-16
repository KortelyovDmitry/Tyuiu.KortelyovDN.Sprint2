using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KortelyovDN.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (y >= 0) && (Math.Pow(x, 2) + Math.Pow(y, 2) >= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4);
            return res;
        }
    }
}