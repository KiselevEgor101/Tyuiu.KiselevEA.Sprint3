using Tyuiu.KiselevEA.Sprint3.Task0.V2.Lib;
namespace Tyuiu.KiselevEA.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}