using Tyuiu.KortelyovDN.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KortelyovDN.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите порядковый номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfNextDay(m, n);

            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadKey();
        }
    }
}