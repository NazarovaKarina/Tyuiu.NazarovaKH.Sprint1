using Tyuiu.NazarovaKH.Sprint1.Task3.V15.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 3;
            double T = 2;
            double S = 5;
            var res = ds.DistanceOverTime(v1, v2, T, S);
            Assert.AreEqual(15, res);
        }
    }
}