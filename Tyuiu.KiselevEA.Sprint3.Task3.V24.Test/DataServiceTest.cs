using Tyuiu.KiselevEA.Sprint3.Task3.V24.Lib;
namespace Tyuiu.KiselevEA.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceCharInString()
        {
            DataService ds = new DataService();

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char rep = '*';

            string res = ds.ReplaceCharInString(value, replaceable, rep);
            string wait = "*ft h**t nt*";

            Assert.AreEqual(wait, res);
        }
    }
}