using MyApp;

namespace MyApp.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Calculator cal = new Calculator();

            int res = cal.Add(2, 3);

            Assert.AreEqual(5,res);
        }
    }
}