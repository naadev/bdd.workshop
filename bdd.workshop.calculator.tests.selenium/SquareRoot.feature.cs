﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace bdd.workshop.calculator.tests.selenium
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SquareRootFeature : object, Xunit.IClassFixture<SquareRootFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SquareRoot.feature"
#line hidden
        
        public SquareRootFeature(SquareRootFeature.FixtureData fixtureData, bdd_workshop_calculator_tests_selenium_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "SquareRoot", "\tAs Alice (the customer)\r\n\tI want to know the square root of a number\r\n\tSo I can " +
                    "organize my inventory", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Checking several square roots")]
        [Xunit.TraitAttribute("FeatureTitle", "SquareRoot")]
        [Xunit.TraitAttribute("Description", "Checking several square roots")]
        [Xunit.InlineDataAttribute("1", "1", new string[0])]
        [Xunit.InlineDataAttribute("2", "1.41", new string[0])]
        [Xunit.InlineDataAttribute("3", "1.73", new string[0])]
        [Xunit.InlineDataAttribute("4", "2", new string[0])]
        [Xunit.InlineDataAttribute("5", "2.24", new string[0])]
        [Xunit.InlineDataAttribute("6", "2.45", new string[0])]
        [Xunit.InlineDataAttribute("7", "2.65", new string[0])]
        [Xunit.InlineDataAttribute("8", "2.83", new string[0])]
        [Xunit.InlineDataAttribute("9", "3", new string[0])]
        [Xunit.InlineDataAttribute("10", "3.16", new string[0])]
        [Xunit.InlineDataAttribute("16", "4", new string[0])]
        [Xunit.InlineDataAttribute("20", "4.47", new string[0])]
        [Xunit.InlineDataAttribute("25", "5", new string[0])]
        [Xunit.InlineDataAttribute("30", "5.47", new string[0])]
        [Xunit.InlineDataAttribute("36", "6", new string[0])]
        [Xunit.InlineDataAttribute("49", "7", new string[0])]
        [Xunit.InlineDataAttribute("64", "8", new string[0])]
        [Xunit.InlineDataAttribute("81", "9", new string[0])]
        [Xunit.InlineDataAttribute("100", "10", new string[0])]
        [Xunit.InlineDataAttribute("121", "11", new string[0])]
        public virtual void CheckingSeveralSquareRoots(string number, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checking several square roots", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
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
#line 8
 testRunner.When(string.Format("number {0} is added", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then(string.Format("the result of the square root is {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SquareRootFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SquareRootFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion