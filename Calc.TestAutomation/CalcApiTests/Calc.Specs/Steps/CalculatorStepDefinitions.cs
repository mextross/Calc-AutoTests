using TechTalk.SpecFlow;
using CalcApiTests;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Calc.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private List<decimal> firstNumbers = new List<decimal>();
        private List<decimal> secondNumbers = new List<decimal>();
        private List<decimal> actualResults = new List<decimal>();
        private CalcAPITests calcAPITests;

        /*Converts the list of first numbers in the feature file table into a decimal list*/
        [Given(@"I have the first number")]
        public void GivenIHaveTheFirstInteger(Table table)
        {
            firstNumbers = table.Rows.Select(x => Convert.ToDecimal(x["Number1"])).ToList();
        }

        /*Converts the list of second numbers in the feature file table into a decimal list*/
        [Given(@"the second number")]
        public void GivenTheSecondInteger(Table table)
        {
            secondNumbers = table.Rows.Select(x => Convert.ToDecimal(x["Number2"])).ToList();
        }

        /*Depending on the operator, the api call is triggered and retrieves the actual results*/
        [When(@"both numbers are (.*)")]
        public void WhenBothIntegersAre(string action)
        {
            if (action == "added")
            {
                calcAPITests = new CalcAPITests("+");
            }
            else if (action == "subtracted")
            {
                calcAPITests = new CalcAPITests("-");
            }

            else if (action == "multiplied")
            {
                calcAPITests = new CalcAPITests("*");
            }
            else if (action == "divided")
            {
                calcAPITests = new CalcAPITests("/");
            }
            actualResults = firstNumbers.Zip(secondNumbers, (a, b) => calcAPITests.Calculate(a, b)).ToList();
        }

        /*Converts the list of expected results in the feature file table into a decimal list
         and then compares expected results in the feature file with actual results from the api*/
        [Then(@"the answer should be the following")]
        public void ThenTheAnswerShouldBeTheFollowing(Table table)
        {
            var expectedResults = table.Rows.Select(x => Convert.ToDecimal(x["Result"])).ToList();
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}






