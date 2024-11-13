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
            double x = 5;
            double wait = 0.026;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}