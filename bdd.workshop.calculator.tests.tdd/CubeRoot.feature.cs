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
namespace bdd.workshop.calculator.tests.tdd
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CubeRootFeature : object, Xunit.IClassFixture<CubeRootFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CubeRoot.feature"
#line hidden
        
        public CubeRootFeature(CubeRootFeature.FixtureData fixtureData, bdd_workshop_calculator_tests_tdd_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "CubeRoot", "\tAs Alice (the customer)\r\n\tI want to know the cube root of a number\r\n\tSo I can or" +
                    "ganize my inventory", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Checking several cube roots")]
        [Xunit.TraitAttribute("FeatureTitle", "CubeRoot")]
        [Xunit.TraitAttribute("Description", "Checking several cube roots")]
        [Xunit.InlineDataAttribute("1", "1", new string[0])]
        [Xunit.InlineDataAttribute("2", "1.26", new string[0])]
        [Xunit.InlineDataAttribute("3", "1.44", new string[0])]
        [Xunit.InlineDataAttribute("4", "1.59", new string[0])]
        [Xunit.InlineDataAttribute("5", "1.71", new string[0])]
        [Xunit.InlineDataAttribute("6", "1.82", new string[0])]
        [Xunit.InlineDataAttribute("7", "1.91", new string[0])]
        [Xunit.InlineDataAttribute("8", "2", new string[0])]
        [Xunit.InlineDataAttribute("9", "2.08", new string[0])]
        [Xunit.InlineDataAttribute("10", "2.15", new string[0])]
        [Xunit.InlineDataAttribute("16", "2.52", new string[0])]
        [Xunit.InlineDataAttribute("20", "2.71", new string[0])]
        [Xunit.InlineDataAttribute("25", "2.92", new string[0])]
        [Xunit.InlineDataAttribute("27", "3", new string[0])]
        [Xunit.InlineDataAttribute("30", "3.11", new string[0])]
        [Xunit.InlineDataAttribute("36", "3.30", new string[0])]
        [Xunit.InlineDataAttribute("49", "3.65", new string[0])]
        [Xunit.InlineDataAttribute("64", "4", new string[0])]
        [Xunit.InlineDataAttribute("81", "4.33", new string[0])]
        [Xunit.InlineDataAttribute("100", "4.64", new string[0])]
        [Xunit.InlineDataAttribute("121", "4.95", new string[0])]
        public virtual void CheckingSeveralCubeRoots(string number, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checking several cube roots", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
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
#line 7
 testRunner.When(string.Format("number {0} is added for cube root", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then(string.Format("the result of the cube root is {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                CubeRootFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CubeRootFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
