using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;
using System.Collections.Generic;

namespace CurrencyConverterTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Converting_1_Eur_To_Pln_Should_Return_4_5201()
        {
            new Calculator();

            double result = Calculator.ConvertEUR(1, "PLN");

            Assert.AreEqual(4.5201, result);
        }
        
        [TestMethod]
        public void Converting_22_Eur_To_Gbp_Should_Return_18_3535()
        {
            new Calculator();

            double result = Calculator.ConvertEUR(22, "GBP");

            Assert.AreEqual(18.3535, result);
        }

        [TestMethod]
        public void Chf_Should_Be_A_Currency()
        {
            new Calculator();

            bool result = Calculator.IsItACurrency("CHF");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Zloty_Should_Not_Be_A_Currency()
        {
            new Calculator();

            bool result = Calculator.IsItACurrency("zloty");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Date_Should_Return_18_02_2022()
        {
            new Calculator();

            string date = Calculator.Date;

            Assert.AreEqual("2022-02-18", date);
        }

        [TestMethod]
        public void Rate_For_Yens_Should_Be_130_59()
        {
            new Calculator();

            Dictionary<string, double> rates = Calculator.Rates;
            double result = rates["JPY"];

            Assert.AreEqual(130.59, result);
        }
    }
}