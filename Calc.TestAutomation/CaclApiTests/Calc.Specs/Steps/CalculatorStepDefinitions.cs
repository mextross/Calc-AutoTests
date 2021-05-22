﻿using TechTalk.SpecFlow;
using CalcApiTests;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
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
        private List<decimal> totals = new List<decimal>();
        private CalcAPITests calcAPITests;

        [Given(@"I have the first number")]
        public void GivenIHaveTheFirstInteger(Table table)
        {
            firstNumbers = table.Rows.Select(x => Convert.ToDecimal(x["Number1"])).ToList();
        }

        [Given(@"the second number")]
        public void GivenTheSecondInteger(Table table)
        {
            secondNumbers = table.Rows.Select(x => Convert.ToDecimal(x["Number2"])).ToList();
        }

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
            totals = firstNumbers.Zip(secondNumbers, (a, b) => calcAPITests.Calculate(a, b)).ToList();
        }

        [Then(@"the answer should be the following")]
        public void ThenTheAnswerShouldBeTheFollowing(Table table)
        {
            var expectedResults = table.Rows.Select(x => Convert.ToDecimal(x["Result"])).ToList();
            Assert.AreEqual(expectedResults, totals);
        }

    }
}






