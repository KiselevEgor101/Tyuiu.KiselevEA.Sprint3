using Tyuiu.KiselevEA.Sprint3.Task6.V26.Lib;
namespace Tyuiu.KiselevEA.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int st = 15;
            int sp = 22;

            int res = ds.GetSumTheDivisors(st, sp);

            int wait = 33;

            Assert.AreEqual(wait, res);
        }
    }
}