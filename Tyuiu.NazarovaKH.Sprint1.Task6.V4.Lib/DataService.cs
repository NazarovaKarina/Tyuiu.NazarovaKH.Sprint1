using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarovaKH.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            value = value.Replace(",", "");
            value = value.Replace(".", "");
            value = value.Replace("?", "");
            value = value.Replace("!", "");
            string[] s = value.Split(' ');
            string a = "";

            foreach (var i in s)
            {
                if (i.Contains("нн"))
                {
                    a += i + " ";
                }
            }

            a = a.Trim();

            return a;
        }
    }
}
