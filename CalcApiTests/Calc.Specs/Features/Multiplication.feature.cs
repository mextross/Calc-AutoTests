﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.8.0.0
//      SpecFlow Generator Version:3.8.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Calc.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Multiplication")]
    public partial class MultiplicationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Multiplication.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Multiplication", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 2 positive integers")]
        [NUnit.Framework.CategoryAttribute("multiplyingIntegers")]
        [NUnit.Framework.TestCaseAttribute("0", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("1", "2", "2", null)]
        [NUnit.Framework.TestCaseAttribute("2", "1", "2", null)]
        [NUnit.Framework.TestCaseAttribute("3", "4", "12", null)]
        [NUnit.Framework.TestCaseAttribute("6", "5", "30", null)]
        [NUnit.Framework.TestCaseAttribute("8", "7", "56", null)]
        [NUnit.Framework.TestCaseAttribute("1", "9", "9", null)]
        [NUnit.Framework.TestCaseAttribute("1", "999", "999", null)]
        [NUnit.Framework.TestCaseAttribute("99", "10", "990", null)]
        [NUnit.Framework.TestCaseAttribute("34", "58", "1972", null)]
        [NUnit.Framework.TestCaseAttribute("99", "1", "99", null)]
        [NUnit.Framework.TestCaseAttribute("999", "999", "998001", null)]
        [NUnit.Framework.TestCaseAttribute("998", "998", "996004", null)]
        public virtual void Mutiplying2PositiveIntegers(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingIntegers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 2 positive integers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 2 negative integers")]
        [NUnit.Framework.CategoryAttribute("multiplyingIntegers")]
        [NUnit.Framework.TestCaseAttribute("-99", "-99", "9801", null)]
        [NUnit.Framework.TestCaseAttribute("-1", "-2", "2", null)]
        [NUnit.Framework.TestCaseAttribute("-3", "-4", "12", null)]
        [NUnit.Framework.TestCaseAttribute("-5", "-6", "30", null)]
        [NUnit.Framework.TestCaseAttribute("-7", "-8", "56", null)]
        [NUnit.Framework.TestCaseAttribute("-9", "-1", "9", null)]
        [NUnit.Framework.TestCaseAttribute("-34", "-58", "1972", null)]
        [NUnit.Framework.TestCaseAttribute("-99", "-1", "99", null)]
        [NUnit.Framework.TestCaseAttribute("-999", "-999", "998001", null)]
        public virtual void Mutiplying2NegativeIntegers(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingIntegers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 2 negative integers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 28
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 29
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 1 positive and 1 negative integer")]
        [NUnit.Framework.CategoryAttribute("multiplyingIntegers")]
        [NUnit.Framework.TestCaseAttribute("1", "-2", "-2", null)]
        [NUnit.Framework.TestCaseAttribute("-3", "4", "-12", null)]
        [NUnit.Framework.TestCaseAttribute("5", "-6", "-30", null)]
        [NUnit.Framework.TestCaseAttribute("-7", "8", "-56", null)]
        [NUnit.Framework.TestCaseAttribute("9", "-1", "-9", null)]
        [NUnit.Framework.TestCaseAttribute("-34", "58", "-1972", null)]
        [NUnit.Framework.TestCaseAttribute("99", "-1", "-99", null)]
        [NUnit.Framework.TestCaseAttribute("-1", "999", "-999", null)]
        [NUnit.Framework.TestCaseAttribute("-999", "999", "-998001", null)]
        public virtual void Mutiplying1PositiveAnd1NegativeInteger(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingIntegers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 1 positive and 1 negative integer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 0 and an integer")]
        [NUnit.Framework.CategoryAttribute("multiplyingIntegers")]
        [NUnit.Framework.TestCaseAttribute("-1", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "2", "0", null)]
        [NUnit.Framework.TestCaseAttribute("3", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "-4", "0", null)]
        [NUnit.Framework.TestCaseAttribute("5", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "6", "0", null)]
        [NUnit.Framework.TestCaseAttribute("7", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "8", "0", null)]
        [NUnit.Framework.TestCaseAttribute("9", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "100", "0", null)]
        [NUnit.Framework.TestCaseAttribute("-999", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "-0", "0", null)]
        public virtual void Mutiplying0AndAnInteger(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingIntegers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 0 and an integer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 66
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 67
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 68
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 2 large integers")]
        [NUnit.Framework.CategoryAttribute("multiplyingIntegers")]
        [NUnit.Framework.TestCaseAttribute("86436", "7896", "682498656", null)]
        [NUnit.Framework.TestCaseAttribute("864360", "78960", "68249865600", null)]
        public virtual void Mutiplying2LargeIntegers(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingIntegers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 2 large integers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 89
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 90
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 91
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 2 positive decimals")]
        [NUnit.Framework.CategoryAttribute("multiplyingDecimals")]
        [NUnit.Framework.TestCaseAttribute("1.52", "3.67", "5.5784", null)]
        public virtual void Mutiplying2PositiveDecimals(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingDecimals"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 2 positive decimals", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 102
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 103
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 104
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 2 negative decimals")]
        [NUnit.Framework.CategoryAttribute("multiplyingDecimals")]
        [NUnit.Framework.TestCaseAttribute("-0.7", "-2.8", "1.96", null)]
        public virtual void Mutiplying2NegativeDecimals(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingDecimals"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 2 negative decimals", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 114
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 115
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 116
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 118
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mutiplying 1 positive and 1 negative decimal")]
        [NUnit.Framework.CategoryAttribute("multiplyingDecimals")]
        [NUnit.Framework.TestCaseAttribute("-9.5", "3.2", "-30.4", null)]
        public virtual void Mutiplying1PositiveAnd1NegativeDecimal(string leftNumber, string rightNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplyingDecimals"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("leftNumber", leftNumber);
            argumentsOfScenario.Add("rightNumber", rightNumber);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mutiplying 1 positive and 1 negative decimal", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 126
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 127
  testRunner.Given(string.Format("I have a first number {0}", leftNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 128
  testRunner.And(string.Format("I have a second number {0}", rightNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
  testRunner.When("both numbers are multiplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
  testRunner.Then(string.Format("I should have the following {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
