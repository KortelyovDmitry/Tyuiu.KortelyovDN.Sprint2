using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KortelyovDN.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int dnivmes;

            switch (m)
            {
                case 2:
                    dnivmes = 28; 
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dnivmes = 30;
                    break;
                default:
                    dnivmes = 31;
                    break;
            }
   
            if (n < dnivmes)
            {
                n++;
            }
            else
            {
                n = 1;
                m++;
            }

            return $"{n:D2}.{m:D2}";
        }
    }
}