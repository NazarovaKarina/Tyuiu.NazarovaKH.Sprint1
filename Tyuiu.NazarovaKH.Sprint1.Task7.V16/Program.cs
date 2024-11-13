using Tyuiu.NazarovaKH.Sprint1.Task7.V16.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                 cos(x^2)                                                *");
            Console.WriteLine("* z = sin(√x^2) + -------- - sin(√x^2 -1)                                 *");
            Console.WriteLine("*                   3x^2                                                  *");

            double x;

            Console.WriteLine("Введите значение х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
