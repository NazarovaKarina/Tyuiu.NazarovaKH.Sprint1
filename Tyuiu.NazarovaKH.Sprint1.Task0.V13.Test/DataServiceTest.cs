using Tyuiu.NazarovaKH.Sprint1.Task0.V13.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}