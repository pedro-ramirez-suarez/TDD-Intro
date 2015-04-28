using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.BL;
using Calculator.Service;
using Moq;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTestService
    {
        IService1 calculator;
        Mock<ISimpleCalculator> moqCalc;


        [TestInitialize]
        public void InitializeCalculator()
        {
            moqCalc = new Mock<ISimpleCalculator>();
            moqCalc.Setup(m => m.Suma(1, 2)).Returns(3);
            moqCalc.Setup(m => m.Resta(1, 2)).Returns(-1);
            moqCalc.Setup(m => m.Division(4, 2)).Returns(2);
            moqCalc.Setup(m => m.Multiplicacion(5, 5)).Returns(25);

            calculator = new Service1(moqCalc.Object);
        }

        [TestMethod]
        public void SumaTestService()
        {
            var result = calculator.Suma(1, 2);
            moqCalc.Verify(v => v.Suma(1, 2));
            Assert.AreEqual(3, result, "Resultados diferentes!");
        }


        [TestMethod]
        public void RestaTestService()
        {
            var result = calculator.Resta(1, 2);
            moqCalc.Verify(v => v.Resta(1, 2));
            Assert.AreEqual(-1, result, "Resultados diferentes!");
        }

        [TestMethod]
        public void DivisionTestService()
        {
            var result = calculator.Division(4, 2);
            moqCalc.Verify(v => v.Division(4, 2));
            Assert.AreEqual(2, result, "Resultados diferentes!");
        }

        [TestMethod]
        public void MultiplicacionTestService()
        {
            var result = calculator.Multiplicacion(5, 5);
            moqCalc.Verify(v => v.Multiplicacion(5, 5));
            Assert.AreEqual(25, result, "Resultados diferentes!");
        }


       
    }
}
