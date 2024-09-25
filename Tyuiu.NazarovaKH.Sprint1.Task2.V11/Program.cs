using Tyuiu.NazarovaKH.Sprint1.Task2.V11.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int hours;

            Console.WriteLine("Введите значение hours:");
            hours = Convert.ToInt32(Console.ReadLine());

            int minutes;

            Console.WriteLine("Введите значение minutes:");
            minutes = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("В 6 часах = " + ds.ConvertHoursMinutesToSeconds(hours, minutes) + " секунд");

            Console.ReadLine();
        }
    }
}
