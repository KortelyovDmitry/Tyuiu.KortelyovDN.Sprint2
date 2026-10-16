using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KortelyovDN.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            return value switch
            {
                12 or 1 or 2 => "Зима",
                3 or 4 or 5 => "Весна",
                6 or 7 or 8 => "Лето",
                9 or 10 or 11 => "Осень",
                _ => throw new ArgumentException($"Месяца с номером {value} не существует.")
            };
        }
    }
}