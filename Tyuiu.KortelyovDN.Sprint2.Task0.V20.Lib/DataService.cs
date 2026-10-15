using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KortelyovDN.Sprint2.Task0.V20.Lib;
public class DataService : ISprint2Task0V20
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] res =
        [
            x == y + 800,
            x != y + 800,
            x < y + 1000,
            x > y + 1000,
            x <= y + 800,
            x >= y + 1000,
        ];
        return res;
    }
}