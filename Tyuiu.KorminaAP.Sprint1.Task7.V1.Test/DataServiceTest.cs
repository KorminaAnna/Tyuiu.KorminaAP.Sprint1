using Tyuiu.KorminaAP.Sprint1.Task7.V1.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3;
            double b = 2;
            double c = 1;
            double wait = -25.75;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
