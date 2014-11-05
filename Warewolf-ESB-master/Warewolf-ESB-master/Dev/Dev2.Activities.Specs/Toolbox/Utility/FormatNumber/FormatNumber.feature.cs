
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Toolbox.Utility.FormatNumber
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FormatNumberFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FormatNumber.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FormatNumber", "In order to round off numbers\r\nAs a Warewolf user\r\nI want a tool that will aid me" +
                    " to do so", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "FormatNumber")))
            {
                Dev2.Activities.Specs.Toolbox.Utility.FormatNumber.FormatNumberFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding normal with zero rounding and zero decimals to show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingNormalWithZeroRoundingAndZeroDecimalsToShow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding normal with zero rounding and zero decimals to show", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I selected rounding \"Normal\" to 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I want to show 0 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the result 789 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table1.AddRow(new string[] {
                        "788.894564545645",
                        "Normal",
                        "0",
                        "0"});
#line 13
 testRunner.And("the debug inputs as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2.AddRow(new string[] {
                        "[[result]] = 789"});
#line 16
 testRunner.And("the debug output as", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding down")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingDown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding down", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("I selected rounding \"Down\" to 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("I want to show 3 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the result 788.894 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table3.AddRow(new string[] {
                        "788.894564545645",
                        "Down",
                        "3",
                        "3"});
#line 27
 testRunner.And("the debug inputs as", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table4.AddRow(new string[] {
                        "[[result]] = 788.894"});
#line 30
 testRunner.And("the debug output as", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding up")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingUp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding up", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.And("I selected rounding \"Up\" to 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I want to show 3 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the result 788.895 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table5.AddRow(new string[] {
                        "788.894564545645",
                        "Up",
                        "3",
                        "3"});
#line 41
 testRunner.And("the debug inputs as", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table6.AddRow(new string[] {
                        "[[result]] = 788.895"});
#line 44
 testRunner.And("the debug output as", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding normal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingNormal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding normal", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("I selected rounding \"Normal\" to 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("I want to show 3 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("the result 788.890 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table7.AddRow(new string[] {
                        "788.894564545645",
                        "Normal",
                        "2",
                        "3"});
#line 55
 testRunner.And("the debug inputs as", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table8.AddRow(new string[] {
                        "[[result]] = 788.890"});
#line 58
 testRunner.And("the debug output as", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding none")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingNone()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding none", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.And("I selected rounding \"None\" to 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("I want to show 4 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("the result 788.8945 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table9.AddRow(new string[] {
                        "788.894564545645",
                        "None",
                        "0",
                        "4"});
#line 69
 testRunner.And("the debug inputs as", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table10.AddRow(new string[] {
                        "[[result]] = 788.8945"});
#line 72
 testRunner.And("the debug output as", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding down to negative number")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingDownToNegativeNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding down to negative number", ((string[])(null)));
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("I selected rounding \"Down\" to -2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I want to show 0 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("the result 700 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table11.AddRow(new string[] {
                        "788.894564545645",
                        "Down",
                        "-2",
                        "0"});
#line 83
 testRunner.And("the debug inputs as", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table12.AddRow(new string[] {
                        "[[result]] = 700"});
#line 86
 testRunner.And("the debug output as", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number large number to negative decimals")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberLargeNumberToNegativeDecimals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number large number to negative decimals", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line 91
 testRunner.Given("I have a number 788.894564545645", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
 testRunner.And("I selected rounding \"None\" to 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I want to show -2 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("the result 7 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table13.AddRow(new string[] {
                        "788.894564545645",
                        "None",
                        "0",
                        "-2"});
#line 97
 testRunner.And("the debug inputs as", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table14.AddRow(new string[] {
                        "[[result]] = 7"});
#line 100
 testRunner.And("the debug output as", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number single digit to negative decimals")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberSingleDigitToNegativeDecimals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number single digit to negative decimals", ((string[])(null)));
#line 104
this.ScenarioSetup(scenarioInfo);
#line 105
 testRunner.Given("I have a number 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.And("I selected rounding \"None\" to 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("I want to show -2 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.Then("the result 0 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table15.AddRow(new string[] {
                        "7",
                        "None",
                        "0",
                        "-2"});
#line 110
 testRunner.And("the debug inputs as", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table16.AddRow(new string[] {
                        "[[result]] = 0"});
#line 113
 testRunner.And("the debug output as", ((string)(null)), table16, "And ");
#line 116
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number rounding up to a character")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberRoundingUpToACharacter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number rounding up to a character", ((string[])(null)));
#line 118
this.ScenarioSetup(scenarioInfo);
#line 119
 testRunner.Given("I have a number 34.2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 120
 testRunner.And("I selected rounding \"Up\" to \"c\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("I want to show 2 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then("the result \"\" will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table17.AddRow(new string[] {
                        "34.2",
                        "Up",
                        "c",
                        "2"});
#line 125
 testRunner.And("the debug inputs as", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table18.AddRow(new string[] {
                        "[[result]] ="});
#line 128
 testRunner.And("the debug output as", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format non numeric")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNonNumeric()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format non numeric", ((string[])(null)));
#line 144
this.ScenarioSetup(scenarioInfo);
#line 145
 testRunner.Given("I have a number \"asdf\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
 testRunner.And("I selected rounding \"None\" to 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.And("I want to show -2 decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.Then("the result \"\" will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
   testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table19.AddRow(new string[] {
                        "asdf",
                        "None",
                        "0",
                        "-2"});
#line 151
   testRunner.And("the debug inputs as", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table20.AddRow(new string[] {
                        "[[result]] ="});
#line 154
 testRunner.And("the debug output as", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number to charater decimals")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberToCharaterDecimals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number to charater decimals", ((string[])(null)));
#line 158
this.ScenarioSetup(scenarioInfo);
#line 159
 testRunner.Given("I have a number 34.2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 160
 testRunner.And("I selected rounding \"Up\" to \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.And("I want to show \"asdf\" decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.Then("the result \"\" will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
   testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table21.AddRow(new string[] {
                        "34.2",
                        "Up",
                        "1",
                        "asdf"});
#line 165
   testRunner.And("the debug inputs as", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table22.AddRow(new string[] {
                        "[[result]] ="});
#line 168
 testRunner.And("the debug output as", ((string)(null)), table22, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number with multipart variables and numbers for number rounding and decima" +
            "ls to show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberWithMultipartVariablesAndNumbersForNumberRoundingAndDecimalsToShow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number with multipart variables and numbers for number rounding and decima" +
                    "ls to show", ((string[])(null)));
#line 172
this.ScenarioSetup(scenarioInfo);
#line 173
 testRunner.Given("I have a formatnumber variable \"[[int]]\" equal to 788", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 174
 testRunner.And("I have a number \"[[int]].894564545645\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And("I have a formatnumber variable \"[[rounding]]\" equal to 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("I selected rounding \"Up\" to \"-[[rounding]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.And("I have a formatnumber variable \"[[decimals]]\" equal to \"-\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And("I want to show \"[[decimals]]1\" decimals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 180
 testRunner.Then("the result 80 will be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
    testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table23.AddRow(new string[] {
                        "[[int]].894564545645 = 788.894564545645",
                        "Up",
                        "-[[rounding]] = -2",
                        "[[decimals]]1 = -1"});
#line 182
 testRunner.And("the debug inputs as", ((string)(null)), table23, "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table24.AddRow(new string[] {
                        "[[result]] = 80"});
#line 185
 testRunner.And("the debug output as", ((string)(null)), table24, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Format number with negative recordset index for rounding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FormatNumber")]
        public virtual void FormatNumberWithNegativeRecordsetIndexForRounding()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format number with negative recordset index for rounding", ((string[])(null)));
#line 200
this.ScenarioSetup(scenarioInfo);
#line 201
 testRunner.Given("I have a formatnumber variable \"[[int]]\" equal to 788", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 202
 testRunner.And("I have a number \"[[int]].894564545645\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.And("I selected rounding \"Up\" to \"[[my(-1).rounding]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
 testRunner.When("the format number is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 205
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show"});
            table25.AddRow(new string[] {
                        "[[int]].894564545645 = 788.894564545645",
                        "Up",
                        "[[my(-1).rounding]] =",
                        "\"\""});
#line 206
 testRunner.And("the debug inputs as", ((string)(null)), table25, "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table26.AddRow(new string[] {
                        "[[result]] ="});
#line 209
 testRunner.And("the debug output as", ((string)(null)), table26, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion