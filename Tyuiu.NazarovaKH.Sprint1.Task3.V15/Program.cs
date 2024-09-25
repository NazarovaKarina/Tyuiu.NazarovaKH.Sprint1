using Tyuiu.NazarovaKH.Sprint1.Task3.V15.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1 = 1;
            double v2 = 4;
            double T = 2;
            double S = 5;
            Console.WriteLine("Скорость 1 автомобиля = " + v1);
            Console.WriteLine("Скорость 2 автомобиля = " + v2);
            Console.WriteLine("Время = " + T);
            Console.WriteLine("Расстояние между автомобилями изначально = " + S);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между ними через 2 часа = " + ds.DistanceOverTime(v1, v2, T, S));

            Console.ReadKey();
        }
    }
}
