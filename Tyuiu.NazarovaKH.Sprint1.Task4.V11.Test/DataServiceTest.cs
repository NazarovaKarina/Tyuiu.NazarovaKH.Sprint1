using Tyuiu.NazarovaKH.Sprint1.Task4.V11.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}