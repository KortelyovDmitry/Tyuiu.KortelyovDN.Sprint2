using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KortelyovDN.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (y == 2 && x >= 10 && x <= 12) res = true;
            else if (y == 3 && ((x >= 4 && x <= 5) || (x >= 10 && x <= 13))) res = true;
            else if (y == 4 && ((x >= 3 && x <= 5) || (x >= 10 && x <= 13))) res = true;
            else if (y == 5 && x >= 2 && x <= 12) res = true;
            else if (y == 6 && x >= 3 && x <= 8) res = true;
            else if (y == 7 && x >= 4 && x <= 8) res = true;
            else if (y == 8 && x >= 6 && x <= 8) res = true;
            else if (y == 9 && ((x >= 6 && x <= 8) || x == 14)) res = true;
            else if (y == 10 && ((x >= 6 && x <= 8) || x == 14)) res = true;
            else if (y == 11 && x >= 3 && x <= 14) res = true;
            else if (y == 12 && ((x >= 7 && x <= 12) || x == 14)) res = true;
            else if (y == 13 && x == 14) res = true;

            return res;
        }
    }
}