using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RhinoMocksTutorial1;
using Rhino.Mocks;

namespace BankTest
{
    [TestClass]
    public class BankTestSolution
    {
        [TestMethod]
        public void DontCalcInterestIfAmountLessThan500()
        {
            var calculator = new TesterInterestCalculator();
            calculator.Principal = 499.99;
            calculator.InterestRate = 0.05;
            calculator.Time = 2;
            var bank = new Bank(calculator);

            bank.RunProcessing();
            Assert.IsFalse(calculator.CalculateWasCalled);
        }

        [TestMethod]
        public void CalcInterestIfAmountOver500()
        {
            var calculator = new TesterInterestCalculator();
            calculator.Principal = 500.01;
            calculator.InterestRate = 0.05;
            calculator.Time = 2;
            var bank = new Bank(calculator);

            bank.RunProcessing();
            Assert.IsTrue(calculator.CalculateWasCalled);
        }

        [TestMethod]
        public void MockDontCalcInterestIfAmountLessThan500()
        {
            var calculator = MockRepository.GenerateMock<SimpleInterestCalculator>();
            calculator.Principal = 499.99;
            calculator.InterestRate = 0.05;
            calculator.Time = 2;

            var bank = new Bank(calculator);

            bank.RunProcessing();

            calculator.AssertWasNotCalled(c => c.CalculateInterestAmount());
        }

        [TestMethod]
        public void MockCalcInterestIfAmountOver500()
        {
            var calculator = MockRepository.GenerateMock<SimpleInterestCalculator>();
            calculator.Principal = 500.01;
            calculator.InterestRate = 0.05;
            calculator.Time = 2;

            var bank = new Bank(calculator);

            bank.RunProcessing();

            calculator.AssertWasCalled(c => c.CalculateInterestAmount());
        }
    }
}
