using Tyuiu.NazarovaKH.Sprint1.Task6.V4.Lib;

namespace Tyuiu.NazarovaKH.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "������� ��������";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "��������";
            Assert.AreEqual(wait, res);
        }
    }
}