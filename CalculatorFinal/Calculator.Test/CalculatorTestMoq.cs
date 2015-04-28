using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Calculator.BL;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTestMoq
    {

        [TestMethod]
        public void SumaTestMoq()
        {
            var moqCalc = new Mock<ISimpleCalculator>();
            moqCalc.Setup(m=> m.Suma(1,2)).Returns(3);
            var result = moqCalc.Object.Suma(1, 2);
            Assert.AreEqual(3, result, "Resultados diferentes!");
        }


        [TestMethod]
        public void RestaTestMoq()
        {
            var moqCalc = new Mock<ISimpleCalculator>();
            moqCalc.Setup(m => m.Resta(1, 2)).Returns(-1);
            var result = moqCalc.Object.Resta(1, 2);
            Assert.AreEqual(-1, result, "Resultados diferentes!");
        }

        [TestMethod]
        public void DivisionTestMoq()
        {
            var moqCalc = new Mock<ISimpleCalculator>();
            moqCalc.Setup(m => m.Division(4, 2)).Returns(2);
            var result = moqCalc.Object.Division(4, 2);
            Assert.AreEqual(2, result, "Resultados diferentes!");
        }

        [TestMethod]
        public void MultiplicacionTestMoq()
        {
            var moqCalc = new Mock<ISimpleCalculator>();
            moqCalc.Setup(m => m.Multiplicacion(5, 5)).Returns(25);
            var result = moqCalc.Object.Multiplicacion(5, 5);
            Assert.AreEqual(25, result, "Resultados diferentes!");
        }


       
    }
}
