// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ISIS.Schedule
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Credit Sections")]
    public partial class CreditSectionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreditSections.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Credit Sections", "In order to manage the course schedule\nAs a scheduler\nI want to manage sections", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to CLEM")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToCLEM()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to CLEM", new string[] {
                        "domain"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 9
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 10
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 11
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 12
 testRunner.When("I change the section location to CLEM");
#line 13
 testRunner.Then("the section location is CLEM");
#line 14
 testRunner.And("the topic code is A");
#line 15
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location from TDCJ back to non-TDCJ")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationFromTDCJBackToNon_TDCJ()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location from TDCJ back to non-TDCJ", new string[] {
                        "domain"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 20
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 21
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 22
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 23
 testRunner.And("I have changed the location to CLEM");
#line 24
 testRunner.When("I change the section location to ACC");
#line 25
 testRunner.Then("the section location is ACC");
#line 26
 testRunner.And("the topic code is blank");
#line 27
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to CV")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToCV()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to CV", new string[] {
                        "domain"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 32
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 33
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 34
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 35
 testRunner.When("I change the section location to CV");
#line 36
 testRunner.Then("the section location is CV");
#line 37
 testRunner.And("the topic code is A");
#line 38
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to DAR")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToDAR()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to DAR", new string[] {
                        "domain"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 43
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 44
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 45
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 46
 testRunner.When("I change the section location to DAR");
#line 47
 testRunner.Then("the section location is DAR");
#line 48
 testRunner.And("the topic code is A");
#line 49
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to J1")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToJ1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to J1", new string[] {
                        "domain"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 54
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 55
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 56
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 57
 testRunner.When("I change the section location to J1");
#line 58
 testRunner.Then("the section location is J1");
#line 59
 testRunner.And("the topic code is A");
#line 60
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to J2")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToJ2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to J2", new string[] {
                        "domain"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 65
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 66
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 67
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 68
 testRunner.When("I change the section location to J2");
#line 69
 testRunner.Then("the section location is J2");
#line 70
 testRunner.And("the topic code is A");
#line 71
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to J3")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToJ3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to J3", new string[] {
                        "domain"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 76
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 77
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 78
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 79
 testRunner.When("I change the section location to J3");
#line 80
 testRunner.Then("the section location is J3");
#line 81
 testRunner.And("the topic code is A");
#line 82
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to TER")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToTER()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to TER", new string[] {
                        "domain"});
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 87
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 88
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 89
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 90
 testRunner.When("I change the section location to TER");
#line 91
 testRunner.Then("the section location is TER");
#line 92
 testRunner.And("the topic code is A");
#line 93
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to R1")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToR1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to R1", new string[] {
                        "domain"});
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 98
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 99
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 100
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 101
 testRunner.When("I change the section location to R1");
#line 102
 testRunner.Then("the section location is R1");
#line 103
 testRunner.And("the topic code is A");
#line 104
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change the credit section location to R2")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void ChangeTheCreditSectionLocationToR2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change the credit section location to R2", new string[] {
                        "domain"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line 108
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 109
 testRunner.And("I have created a topic code A Academic TDC Course Code");
#line 110
 testRunner.And("I have created a term 211FA from 8/25/2011 to 12/7/2011");
#line 111
 testRunner.And("I have created a section 01 from the course with term 211FA");
#line 112
 testRunner.When("I change the section location to R2");
#line 113
 testRunner.Then("the section location is R2");
#line 114
 testRunner.And("the topic code is A");
#line 115
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a credit section without a topic code")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CreateACreditSectionWithoutATopicCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a credit section without a topic code", new string[] {
                        "domain"});
#line 118
this.ScenarioSetup(scenarioInfo);
#line 119
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 120
 testRunner.And("I have changed the approval number to 1234567890");
#line 121
 testRunner.And("I have created a term 211FA from 9/1/2011 to 11/30/2011");
#line 122
 testRunner.When("I create section 01 from the course with term 211FA");
#line 123
 testRunner.Then("the section\'s rubric is BIOL");
#line 124
 testRunner.And("the section\'s course number is 1301");
#line 125
 testRunner.And("the section\'s section number is 01");
#line 126
 testRunner.And("the section\'s term is 211FA");
#line 127
 testRunner.And("the section\'s start date is 9/1/2011");
#line 128
 testRunner.And("the section\'s end date is 11/30/2011");
#line 129
 testRunner.And("the section\'s title is \"Introductory Biology\"");
#line 130
 testRunner.And("the section\'s course type is ACAD");
#line 131
 testRunner.And("the section\'s current course type is ACAD");
#line 132
 testRunner.And("the section\'s approval number is 1234567890");
#line 133
 testRunner.And("the section\'s CIP is 123456");
#line 134
 testRunner.And("the location is blank");
#line 135
 testRunner.And("it should do nothing else");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cant create a credit section without an approval number or CIP")]
        [NUnit.Framework.CategoryAttribute("domain")]
        public virtual void CantCreateACreditSectionWithoutAnApprovalNumberOrCIP()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cant create a credit section without an approval number or CIP", new string[] {
                        "domain"});
#line 138
this.ScenarioSetup(scenarioInfo);
#line 139
 testRunner.Given("I have created an ACAD course BIOL 1301 \"Introductory Biology\"");
#line 140
 testRunner.And("I have created a term 211FA from 9/1/2011 to 11/30/2011");
#line 141
 testRunner.When("I create section 01 from the course with term 211FA");
#line 142
 testRunner.Then("the command is invalid");
#line 143
 testRunner.And("the error is \"Your attempt to create the section failed. Set approval number or C" +
                    "IP at the course level first.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion