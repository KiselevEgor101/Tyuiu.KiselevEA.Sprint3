using Tyuiu.KiselevEA.Sprint3.Task7.V4.Lib;
namespace Tyuiu.KiselevEA.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int st = -5;
            int sp = 5;
            int len = sp - st + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -2.15;
            valueWaitArray[1] = -2.57;
            valueWaitArray[2] = -3;
            valueWaitArray[3] = -3.83;
            valueWaitArray[4] = -11.70;
            valueWaitArray[5] = 3;
            valueWaitArray[6] = 2.19;
            valueWaitArray[7] = 3.31;
            valueWaitArray[8] = 2.97;
            valueWaitArray[9] = 1.18;
            valueWaitArray[10] = 0.30;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(st, sp);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}