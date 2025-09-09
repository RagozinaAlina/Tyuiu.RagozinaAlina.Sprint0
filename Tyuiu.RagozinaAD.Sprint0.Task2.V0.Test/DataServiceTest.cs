using Tyuiu.RagozinaAD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RagozinaAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алина";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Алина", res);
        }
    }
}
