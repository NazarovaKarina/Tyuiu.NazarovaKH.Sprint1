using Tyuiu.NazarovaKH.Sprint1.Task2.V11.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int hours = 6;
            int minutes = 60;
            var res = ds.ConvertHoursMinutesToSeconds(hours, minutes);
            Assert.AreEqual(21600, res);
        }
    }
}