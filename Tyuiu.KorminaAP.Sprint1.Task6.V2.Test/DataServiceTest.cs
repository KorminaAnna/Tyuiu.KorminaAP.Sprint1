using Tyuiu.KorminaAP.Sprint1.Task6.V2.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, World";
            DataService ds = new DataService();
            string res = ds.CheckHello(strTest).ToString();
            string wait = "True";
            Assert.AreEqual(wait, res);

        }
    }
}
