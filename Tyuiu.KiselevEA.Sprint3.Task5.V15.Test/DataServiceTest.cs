using Tyuiu.KiselevEA.Sprint3.Task5.V15.Lib;
namespace Tyuiu.KiselevEA.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 3;
            int startValue2 = 10;
            int stopValue1 = 1;
            int stopValue2 = 1;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}