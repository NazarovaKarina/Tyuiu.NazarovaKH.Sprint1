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
            double v1 = 1;
            double v2 = 5;
            double T = 3;
            double S = 2;
            var res = ds.DistanceOverTime(v1, v2, T, S);
            Assert.AreEqual(115, res);
        }
    }
}