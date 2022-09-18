using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Preactica2Unidad2.Tests
{
    [TestClass()]
    public class DivisorTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            //arrange

            double num1 = 4;
            double num2 = 2;
            double respuestaEsperada = 2;
            double resultado = 2;
     
            //act

             Divisor.Division(num1, num2);

            //assert

            Assert.AreEqual(respuestaEsperada, resultado);
        }
    }
}