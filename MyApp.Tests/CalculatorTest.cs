using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyApp;

namespace MyApp.Tests
{
    public class CalculatorTest
    {
        [Test]
        public void Add_Test()
        {
            Calculator cal = new Calculator();

            int res = cal.Add(2, 3);

            Assert.AreEqual(5, res);
        }
    }
}
