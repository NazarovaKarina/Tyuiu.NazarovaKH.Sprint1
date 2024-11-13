using Tyuiu.NazarovaKH.Sprint1.Task7.V16.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = Math.Sin(1) + Math.Cos(1) / 3;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}