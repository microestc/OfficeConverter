using OfficeConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new OfficeService();
            service.Convert(new TaskSetup("1000", @"C:\app\1.doc", @"C:\app"));

        }
    }
}
