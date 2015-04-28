using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.BL;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTests
    {

        ISimpleCalculator calculator;

        [TestInitialize]
        public void InitializeCalculator() 
        {
            calculator = new SimpleCalculator();
        }

        [TestMethod]
        public void SumaTest()
        {
            var result = calculator.Suma(1, 2);
            Assert.AreEqual(3, result, "Resultados diferentes!");
        }


        [TestMethod]
        public void RestaTest()
        {
            var result = calculator.Resta(1, 2);
            Assert.AreEqual(-1, result, "Resultados diferentes!");
        }

        [TestMethod]
        public void DivisionTest()
        {
            var result = calculator.Division(4, 2);
            Assert.AreEqual(2, result, "Resultados diferentes!");
        }

        [TestMethod]
        public void MultiplicacionTest()
        {
            var result = calculator.Multiplicacion(5, 5);
            Assert.AreEqual(25, result, "Resultados diferentes!");
        }


        [TestMethod]
        public void DivisionEntreCeroTest()
        {
            //var result = calculator.Division(5, 0);
            //Assert.AreEqual(decimal.Zero, result, "Resultados diferentes!");

            try
            {
                var result = calculator.Division(5, 0);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException));
            }
        }

    }
}
