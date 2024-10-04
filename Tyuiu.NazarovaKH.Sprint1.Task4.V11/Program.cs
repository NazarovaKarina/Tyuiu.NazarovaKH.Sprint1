using Tyuiu.NazarovaKH.Sprint1.Task4.V11.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение arctgx:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение eToY:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("arctgx / eToY = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
