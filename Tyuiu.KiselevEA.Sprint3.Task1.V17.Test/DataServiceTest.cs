using Tyuiu.KiselevEA.Sprint3.Task1.V17.Lib;
namespace Tyuiu.KiselevEA.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 303588635.979;

            Assert.AreEqual(wait, res);
            
        }
    }
}