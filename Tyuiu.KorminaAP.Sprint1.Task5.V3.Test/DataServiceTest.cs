using Tyuiu.KorminaAP.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 130985;
            DataService ds = new DataService();
            int res = ds.Calculate(k);
            int result = Convert.ToInt32(res);
            int wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}
