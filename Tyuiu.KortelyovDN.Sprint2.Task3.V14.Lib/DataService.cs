using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KortelyovDN.Sprint2.Task3.V14.Lib
{
    public class DataService : ISprint2Task3V14
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x - Math.Pow((x + 1) / (x - 1), 3);
            }
            else if (x == 0)
            {
                y = (3 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 3)) + 10) / (4 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 4)) + 12);
            }
            else if (x > -18 && x < 2)
            {
                y = Math.Pow((1 + 1 / Math.Pow(x, 2)), x);
            }
            else if (x < -18)
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
