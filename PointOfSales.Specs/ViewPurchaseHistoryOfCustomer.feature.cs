﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PointOfSales.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ViewPurchaseHistoryOfCustomerFeature : Xunit.IUseFixture<ViewPurchaseHistoryOfCustomerFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ViewPurchaseHistoryOfCustomer.feature"
#line hidden
        
        public ViewPurchaseHistoryOfCustomerFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "View purchase history of customer", "In order to find customers which spend money\nAs a salesman\nI want to be able to v" +
                    "iew the purchase history of a customer", ProgrammingLanguage.CSharp, new string[] {
                        "customers",
                        "orders"});
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
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "EmailAddress"});
            table1.AddRow(new string[] {
                        "John",
                        "Doe",
                        "john.doe@mail.com"});
            table1.AddRow(new string[] {
                        "Jack",
                        "Finney",
                        "jack@mail.com"});
#line 8
 testRunner.Given("there are following customers in the shop", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Customer",
                        "Date"});
            table2.AddRow(new string[] {
                        "John Doe",
                        "2014-06-04"});
            table2.AddRow(new string[] {
                        "John Doe",
                        "2014-07-29"});
#line 12
 testRunner.And("there are following orders in the shop", ((string)(null)), table2, "And ");
#line hidden
        }
        
        public virtual void SetFixture(ViewPurchaseHistoryOfCustomerFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "View purchase history of customer")]
        [Xunit.TraitAttribute("Description", "Customer without orders does not have purchase history")]
        public virtual void CustomerWithoutOrdersDoesNotHavePurchaseHistory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer without orders does not have purchase history", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 19
 testRunner.When("I view purchase history of \'Jack Finney\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("I do not see any orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "View purchase history of customer")]
        [Xunit.TraitAttribute("Description", "Customer with orders have pruchase history")]
        public virtual void CustomerWithOrdersHavePruchaseHistory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer with orders have pruchase history", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 23
 testRunner.When("I view purchase history of \'John Doe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Date"});
            table3.AddRow(new string[] {
                        "2014-06-04"});
            table3.AddRow(new string[] {
                        "2014-07-29"});
#line 24
 testRunner.Then("I see following orders", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ViewPurchaseHistoryOfCustomerFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ViewPurchaseHistoryOfCustomerFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
