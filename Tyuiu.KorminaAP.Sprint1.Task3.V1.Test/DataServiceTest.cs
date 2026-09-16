using Tyuiu.KorminaAP.Sprint1.Task3.V1.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 37.699;
            var res = ds.CylinderVolume(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
