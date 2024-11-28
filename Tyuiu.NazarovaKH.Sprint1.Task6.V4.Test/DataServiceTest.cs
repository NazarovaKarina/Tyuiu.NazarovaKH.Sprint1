using Tyuiu.NazarovaKH.Sprint1.Task6.V4.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "зеленый странный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "странный";
            Assert.AreEqual(wait, res);
        }
    }
}