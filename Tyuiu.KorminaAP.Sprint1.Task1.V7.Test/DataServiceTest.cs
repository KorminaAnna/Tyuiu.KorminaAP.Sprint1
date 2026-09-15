using Tyuiu.KorminaAP.Sprint1.Task1.V7.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5.0 / 3.0, res);
        }
    }
}
