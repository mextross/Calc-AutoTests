using CalcApiTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Calc.Specs.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly CalculatorData calcData;
        private readonly CalcAPITests calcAPITests = new CalcAPITests();

        public CalculatorSteps(CalculatorData calcData)
        {
            this.calcData = calcData;
        }

        [Given(@"I have a first number (.*)")]
        public void GivenIHaveAFirstNumber(decimal leftNumber)
        {
            calcData.leftNumber = leftNumber;
        }

        [Given(@"I have a second number (.*)")]
        public void GivenIHaveASecondNumber(decimal rightNumber)
        {
            calcData.rightNumber = rightNumber;
        }

        [When(@"both numbers are (.*)")]
        public void WhenBothNumbersAre(string action)
        {
            switch (action)
            {
                case "added":
                    calcData.op = "+";
                    break;
                case "subtracted":
                    calcData.op = "-";
                    break;
                case "multiplied":
                    calcData.op = "*";
                    break;
                case "divided":
                    calcData.op = "/";
                    break;
            }
            calcData.result = calcAPITests.Calculate(calcData.leftNumber, calcData.rightNumber, calcData.op);
        }

        [Then(@"I should have the following (.*)")]
        public void ThenIShouldHaveTheFollowing(decimal expectedResult)
        {
            Assert.AreEqual(expectedResult, calcData.result);
        }
    }
}

