using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Preactica2Unidad2.Tests
{
    [TestClass()]
    public class DivisorPorCeroTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisorCeroTest()
        {
            //arrange

            int num1 = 10;
            

            //act

            DivisorPorCero.DivisorCero(num1);

        }
    }
}